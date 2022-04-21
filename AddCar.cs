using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Runtime.InteropServices;

namespace Komis
{
    public partial class AddCar : Form
    {
        private List<Car> possibleCars;
        private string pathToCurrentPicture;
        public AddCar()
        {
            possibleCars = ReadPossibleCars();
            InitializeComponent();
            AllowDrop = true;
            AddPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pathToCurrentPicture = null;
        }

        private void AddPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    AddPictureBox.Image = Image.FromFile(filenames[0]);
                    pathToCurrentPicture = filenames[0];
                }
            }
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            BrandsBox.Items.Clear();
            List<string> uniqueBrands = new List<string>();
            foreach (var possibleCar in possibleCars)
            {
                if (!uniqueBrands.Contains(possibleCar.Brand))
                {
                    uniqueBrands.Add(possibleCar.Brand);
                    BrandsBox.Items.Add(possibleCar.Brand);
                }
            }
            
            AddPictureBox.AllowDrop = true;
            
        }

        private List<Car> ReadPossibleCars()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
            };
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            var pathToPossibleCars = projectDirectory + "\\possible_cars.csv";
            List<Car> possibleCars = new List<Car>(); 
            using (var reader = new StreamReader( pathToPossibleCars))
            
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var possibleRecords = csvReader.GetRecords<Car>();
                foreach(var possibleRecord in possibleRecords)
                {
                    possibleCars.Add(possibleRecord);
                }
            }

            return possibleCars;
        }

        private void BrandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelBox.SelectedIndex = -1;
            ModelBox.Items.Clear();

            var selectedBrand = BrandsBox.SelectedItem;
            List<string> uniqueModels = new List<string>();

            foreach (Car possibleCar in possibleCars.FindAll(car => ((string)car.Brand == (string)selectedBrand)))
            {
                if (!uniqueModels.Contains(possibleCar.Model))
                {
                    uniqueModels.Add(possibleCar.Model);
                    ModelBox.Items.Add(possibleCar.Model);
                }
            }
        }

        private void ModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EngineBox.SelectedIndex = -1;
            EngineBox.Items.Clear();
            var selectedBrand = BrandsBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            List<string> uniqueEngines = new List<string>();

            foreach (Car possibleCar in possibleCars.FindAll(car => ((string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel)))
            {
                if (!uniqueEngines.Contains(possibleCar.Engine))
                {
                    uniqueEngines.Add(possibleCar.Engine);
                    EngineBox.Items.Add(possibleCar.Engine);
                }
            }
        }

        private void EngineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorBox.SelectedIndex = -1;
            ColorBox.Items.Clear();
            var selectedBrand = BrandsBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            var selectedEngine = EngineBox.SelectedItem;
            List<string> uniqueColors = new List<string>();

            foreach (Car possibleCar in possibleCars.FindAll(car => (string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel && (string)car.Engine == (string)selectedEngine))
            {
                if (!uniqueColors.Contains(possibleCar.Color))
                {
                    uniqueColors.Add(possibleCar.Color);
                    ColorBox.Items.Add(possibleCar.Color);
                }
            }
        }

        private void AddPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CancelAddingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            EngineBox.SelectedIndex = -1;
            ModelBox.SelectedIndex = -1;
            BrandsBox.SelectedIndex = -1;
            ColorBox.SelectedIndex = -1;
            AddPictureBox.Image = null;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if(EngineBox.SelectedIndex != -1
                && ModelBox.SelectedIndex != -1
                && BrandsBox.SelectedIndex != -1
                && ColorBox.SelectedIndex != -1
                && AddPictureBox.Image != null)
            {
                // dodaj rekord do listy posiadanych
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                };
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                var pathToOwnedCars = projectDirectory + "\\owned_cars.csv";
                List<Car> ownedCars = new List<Car>();
                using (var reader = new StreamReader(pathToOwnedCars))

                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var possibleRecords = csvReader.GetRecords<Car>();
                    foreach (var possibleRecord in possibleRecords)
                    {
                        ownedCars.Add(possibleRecord);
                    }
                }
                int lastIndex;
                if (ownedCars.Count > 0)
                {
                    lastIndex = ownedCars[ownedCars.Count - 1].Id;
                }
                else
                {
                    lastIndex = 0;
                }
                

                Car newCar = new Car();
                newCar.Id = lastIndex + 1;
                newCar.Brand = BrandsBox.SelectedItem.ToString();
                newCar.Model = ModelBox.SelectedItem.ToString();
                newCar.Engine = EngineBox.SelectedItem.ToString();
                newCar.Color = ColorBox.SelectedItem.ToString();

                var records = new List<Car>
                {
                    newCar,
                };
                config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(pathToOwnedCars, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
                var pictureFolder = Path.Combine( projectDirectory, "CarPictures");
                var picturePath = Path.Combine(pictureFolder, "Picture" + newCar.Id.ToString() + ".png");
                File.Copy(pathToCurrentPicture, picturePath, true);
            }
            else
            {
                // pokaz okno ze ma wypelnic wszystkie pola razem ze zdjeciem
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("You nedd to fill all list boxes and add a picture to add car", "", button);
            }
        }
    }
}
