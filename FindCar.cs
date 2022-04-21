using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public partial class FindCar : Form
    {
        private List<Car> ownedCars;
        public FindCar()
        {
            InitializeComponent();
            ownedCars = ReadOwnedCars();
            ViewCarBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private List<Car> ReadOwnedCars(){
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
            };
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            var pathToPossibleCars = projectDirectory + "\\owned_cars.csv";
            List<Car> ownedCars = new List<Car>();
            using (var reader = new StreamReader(pathToPossibleCars))

            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var possibleRecords = csvReader.GetRecords<Car>();
                foreach (var possibleRecord in possibleRecords)
                {
                    ownedCars.Add(possibleRecord);
                }
            }

            return ownedCars;
        }

        private void FindCar_Load(object sender, EventArgs e)
        {
            BrandComboBox.Items.Clear();
            List<string> uniqueBrands = new List<string>();
            foreach (var possibleCar in ownedCars)
            {
                if (!uniqueBrands.Contains(possibleCar.Brand))
                {
                    uniqueBrands.Add(possibleCar.Brand);
                    BrandComboBox.Items.Add(possibleCar.Brand);
                }
            }
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelComboBox.SelectedIndex = -1;
            ModelComboBox.Items.Clear();

            var selectedBrand = BrandComboBox.SelectedItem;
            List<string> uniqueModels = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand)))
            {
                if (!uniqueModels.Contains(possibleCar.Model))
                {
                    uniqueModels.Add(possibleCar.Model);
                    ModelComboBox.Items.Add(possibleCar.Model);
                }
            }
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EngineComboBox.SelectedIndex = -1;
            EngineComboBox.Items.Clear();
            var selectedBrand = BrandComboBox.SelectedItem;
            var selectedModel = ModelComboBox.SelectedItem;
            List<string> uniqueEngines = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel)))
            {
                if (!uniqueEngines.Contains(possibleCar.Engine))
                {
                    uniqueEngines.Add(possibleCar.Engine);
                    EngineComboBox.Items.Add(possibleCar.Engine);
                }
            }
        }

        private void EngineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorComboBox.SelectedIndex = -1;
            ColorComboBox.Items.Clear();
            var selectedBrand = BrandComboBox.SelectedItem;
            var selectedModel = ModelComboBox.SelectedItem;
            var selectedEngine = EngineComboBox.SelectedItem;
            List<string> uniqueColors = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel) && (string)car.Engine == (string)selectedEngine))
            {
                if (!uniqueColors.Contains(possibleCar.Color))
                {
                    uniqueColors.Add(possibleCar.Color);
                    ColorComboBox.Items.Add(possibleCar.Color);
                }
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBrand = BrandComboBox.SelectedItem;
            var selectedModel = ModelComboBox.SelectedItem;
            var selectedEngine = EngineComboBox.SelectedItem;
            var selectedColor = ColorComboBox.SelectedItem;
            ViewCarBox.Image = null;
            ViewCarBox.ImageLocation = null;
            
            var pickedCar = ownedCars.Find(car => (string)car.Brand == (string)selectedBrand && (string)car.Model == (string) selectedModel && (string)car.Engine == (string)selectedEngine && (string)car.Color == (string)selectedColor);
            if (pickedCar != null)
            {
                int idOfPickedCar = pickedCar.Id;

                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // or: Directory.GetCurrentDirectory() gives the same result

                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

                var pathToPossibleCars = Path.Combine(projectDirectory, "CarPictures", "Picture" + idOfPickedCar.ToString() + ".png");

                ViewCarBox.ImageLocation = pathToPossibleCars;
            }
        }
    }
}
