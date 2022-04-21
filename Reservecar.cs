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
    public partial class Reservecar : Form
    {
        private List<Car> ownedCars;
        private List<Reservation> reservations;
        public Reservecar()
        {
            InitializeComponent();
            ownedCars = ReadOwnedCars();
            CarPreviewBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private List<Car> ReadOwnedCars()
        {
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

        private List<Reservation> ReadReservations()
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            var pathToPossibleCars = projectDirectory + "\\reservations.csv";
            List<Reservation> reservations = new List<Reservation>();
            using (var reader = new StreamReader(pathToPossibleCars))

            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var possibleRecords = csvReader.GetRecords<Reservation>();
                foreach (var possibleRecord in possibleRecords)
                {
                    reservations.Add(possibleRecord);
                }
            }

            return reservations;
        }

        private void BrandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelBox.SelectedIndex = -1;
            ModelBox.Items.Clear();

            var selectedBrand = BrandBox.SelectedItem;
            List<string> uniqueModels = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand)))
            {
                if (!uniqueModels.Contains(possibleCar.Model))
                {
                    uniqueModels.Add(possibleCar.Model);
                    ModelBox.Items.Add(possibleCar.Model);
                }
            }
        }

        private void Reservecar_Load(object sender, EventArgs e)
        {
            BrandBox.Items.Clear();
            List<string> uniqueBrands = new List<string>();
            foreach (var possibleCar in ownedCars)
            {
                if (!uniqueBrands.Contains(possibleCar.Brand))
                {
                    uniqueBrands.Add(possibleCar.Brand);
                    BrandBox.Items.Add(possibleCar.Brand);
                }
            }
        }

        private void ModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EngineBox.SelectedIndex = -1;
            EngineBox.Items.Clear();
            var selectedBrand = BrandBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            List<string> uniqueEngines = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel)))
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
            var selectedBrand = BrandBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            var selectedEngine = EngineBox.SelectedItem;
            List<string> uniqueColors = new List<string>();

            foreach (Car possibleCar in ownedCars.FindAll(car => ((string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel) && (string)car.Engine == (string)selectedEngine))
            {
                if (!uniqueColors.Contains(possibleCar.Color))
                {
                    uniqueColors.Add(possibleCar.Color);
                    ColorBox.Items.Add(possibleCar.Color);
                }
            }
        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBrand = BrandBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            var selectedEngine = EngineBox.SelectedItem;
            var selectedColor = ColorBox.SelectedItem;
            CarPreviewBox.Image = null;
            CarPreviewBox.ImageLocation = null;

            var pickedCar = ownedCars.Find(car => (string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel && (string)car.Engine == (string)selectedEngine && (string)car.Color == (string)selectedColor);
            if (pickedCar != null)
            {
                int idOfPickedCar = pickedCar.Id;

                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // or: Directory.GetCurrentDirectory() gives the same result

                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

                var pathToPossibleCars = Path.Combine(projectDirectory, "CarPictures", "Picture" + idOfPickedCar.ToString() + ".png");

                CarPreviewBox.ImageLocation = pathToPossibleCars;

                changeCalendarAvailability(idOfPickedCar);
            }
        }

        private void changeCalendarAvailability(int idOfPickedCar)
        {
            reservations = ReadReservations();
            List<Reservation> thisCarReservations = new List<Reservation>();

            foreach (var possibleRecord in reservations)
            {
                if (possibleRecord.CarId == idOfPickedCar)
                {
                    thisCarReservations.Add(possibleRecord);
                }
            }


            TestDrivePicker.RemoveAllBoldedDates();
           
            int year;
            int month;
            int day;

            foreach (Reservation reservation in thisCarReservations)
            {
                var dates = reservation.DriveDate.Split('/');
                year = int.Parse(dates[2]);
                month = int.Parse(dates[0]);
                day = int.Parse(dates[1]);
                DateTime alreadyReserved = new DateTime(year, month, day);
                TestDrivePicker.AddBoldedDate(alreadyReserved);
            }
            TestDrivePicker.UpdateBoldedDates();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            var pickedDateString = TestDrivePicker.SelectionRange.Start.ToShortDateString();
            var chosenDate = TestDrivePicker.SelectionRange.Start;
            var selectedBrand = BrandBox.SelectedItem;
            var selectedModel = ModelBox.SelectedItem;
            var selectedEngine = EngineBox.SelectedItem;
            var selectedColor = ColorBox.SelectedItem;
            if (CarPreviewBox.Image != null && UsernameTextBox.Text != "")
            {
                var pickedCar = ownedCars.Find(car => (string)car.Brand == (string)selectedBrand && (string)car.Model == (string)selectedModel && (string)car.Engine == (string)selectedEngine && (string)car.Color == (string)selectedColor);
                if (TestDrivePicker.BoldedDates.Contains(chosenDate))
                {
                    //find name of username which picked this car on this day
                    var pickedReservation = reservations.Find(reservation => pickedDateString == reservation.DriveDate && pickedCar.Id == reservation.CarId);
                    var username = pickedReservation.Username;
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show("This car is already reserved by " + username + " on chosen day, pick another date", "", button);
                }
                else
                {
                    var newReservation = new Reservation();
                    newReservation.CarId = pickedCar.Id;
                    newReservation.Username = UsernameTextBox.Text;
                    newReservation.DriveDate = pickedDateString;
                    addReservation(newReservation);
                    changeCalendarAvailability(pickedCar.Id);
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show("You have properly reserved a car for given day", "", button);
                }
            }
            else
            {
                // pokaz okno ze ma wypelnic wszystkie pola razem 
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("You need to pick a car, type in username and pick valid date to resesrve car", "", button);
            }
        }

        private void addReservation(Reservation newReservation)
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            var pathToReservations = projectDirectory + "\\reservations.csv";

            var records = new List<Reservation>
            {
                newReservation,
            };
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open(pathToReservations, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
