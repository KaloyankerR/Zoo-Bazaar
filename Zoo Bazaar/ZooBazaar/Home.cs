using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class Home : Form
    {

        RegionManager regionManager = new RegionManager(new RegionDAL());
        BreedsManager breedsManager = new BreedsManager(new BreedDAL());
        CageManager cageManager = new CageManager(new CageDAL());
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());
        EmployeeManager employeeManager = new EmployeeManager(new EmployeeDAL());



        public Home()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            List<ZooRegion> regions = regionManager.ReadAllRegions();
            List<Cage> cages = cageManager.ReadAllCages();
            List<Animal> animals = animalManager.GetAllAnimals();
            List<Breed> breeds = breedsManager.GetAllBreeds();
            List<Employee> employees = employeeManager.GetAllEmployees();

            lblEmployees.Text = employees.Count().ToString();
            lblRegions.Text = regions.Count().ToString();
            lblCages.Text = cages.Count().ToString();
            lblBreeds.Text = breeds.Count().ToString();
            lblAnimals.Text = animals.Count().ToString();


            List<Employee> admins = new List<Employee>();
            List<Employee> HR = new List<Employee>();
            List<Employee> vet = new List<Employee>();
            List<Employee> careTakers = new List<Employee>();


            foreach (Employee emp in employees)
            {
                if (emp.Position == Position.ADMINISTRATOR)
                {
                    admins.Add(emp);
                }
                else if (emp.Position == Position.HR)
                {
                    HR.Add(emp);
                }
                else if (emp.Position == Position.VETARINARY)
                {
                    vet.Add(emp);
                }
                else if (emp.Position == Position.CARETAKER)
                {
                    careTakers.Add(emp);
                }
            }

            lblAdmin.Text = admins.Count().ToString();
            lblHR.Text = HR.Count().ToString();
            lblVet.Text = vet.Count().ToString();
            lblCareTaker.Text = careTakers.Count().ToString();

        }
    }
}
