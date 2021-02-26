using System;
using System.Data;
using System.Windows.Forms;

namespace PC_Part_DataBase
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        int IdNumber = 0;


        private void MainWindows_Load(object sender, EventArgs e)
        {
            DataTable parts = new DataTable();

            parts.Columns.Add("ID");
            parts.Columns.Add("Components");
            parts.Columns.Add("Manufacturer");
            parts.Columns.Add("Subvendor");
            parts.Columns.Add("Part's title");
            parts.Columns.Add("Part's cost");

            parts.Rows.Add(IdNumber, "Processor", "Intel", "i5-8400");

            parts.Rows.Add(IdNumber+1, "Motherboard", "Intel", "H110M");

            parts.Rows.Add(IdNumber+2, "GPU", "Nvidia, Gigabyte", "Geforce GTX 1080 8gb");




            PC_Parts_DataGrid.DataSource = parts;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            IdNumber++;
        }

        private void Components_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets the correct index of the Components lisbox's selected item.
            int correctItem = Components_Listbox.SelectedIndex;

            //Stores all of the case manufacturers (not finished)
            string[] Manufacturer_Case = {"Aigo", "AMAX Information Technologies", "Antec","AOpen","ASRock","Asus","be quiet!","CaseLabs(defunct)","Chassis Plans","Cooler Master","Corsair","Dell",
                    "Deepcool","DFI","ECS","EVGA Corporation","Foxconn", "Fractal Design","Gigabyte Technology","IBall","Lian Li","MSI","MiTAC","NZXT","Phanteks","Razer","Rosewill","Seasonic",
                    "Shuttle","SilverStone Technology","Thermaltake","Ultra Products","XFX","Zalman"};

            //Stores all the CPU manufacturers
            string[] Manufacturer_CPU = {"AMD" ,"Intel"};

            //stores all the CPU cooler manufacturers
            string[] Manufacturer_CPUCooler = { "Aigo",
    "AMD",
    "Antec",
    "Arctic",
    "Asetek",
    "Asus",
    "be quiet!",
    "Cooler Master",
    "Corsair",
    "Deepcool",
    "ebm-papst",
    "Fractal Design",
    "Foxconn",
    "GELID Solutions",
    "Gigabyte Technology",
    "Hama Photo",
    "Intel",
    "Nidec",
    "Noctua",
    "NZXT",
    "Saint-Gobain",
    "SilverStone Technology",
    "Spire",
    "Thermalright",
    "Thermaltake",
    "Ultra Products",
    "Vigor Gaming",
    "Zalman" };

            string[] Manufacturer_GPU = { "AMD", "ATI", "Nvidia" };

            string[] Manufacturer_Mainboard = {
    "Acer",
    "ACube Systems",
    "Albatron",
    "AMAX Information Technologies",
    "AOpen",
    "Asus",
    "ASRock",
    "Biostar",
    "Chassis Plans",
    "DFI",
    "ECS(Elitegroup Computer Systems)",
    "EPoX(partially defunct)",
    "EVGA Corporation",
    "First International Computer",
    "Foxconn",
    "Fujitsu",
    "Gigabyte Technology",
    "Gumstix",
    "Intel",
    "Lanner Inc(industrial motherboards)",
    "Leadtek",
    "Lite - On",
    "MSI (Micro-Star International)",
    "NZXT",
    "PNY Technologies",
    "Powercolor",
    "Sapphire Technology",
    "Shuttle Inc.",
    "Simmtronics",
    "Supermicro",
    "Tyan",
    "VIA Technologies",
    "Vigor Gaming",
    "XFX",
    "ZOTAC" };

            string[] Manufacturer_RAM = {

    "ADATA",
    "Apacer",
   " Asus",
   " Axiom",
   " Buffalo Technology",
   " Chaintech",
    "Corsair",
    "Crucial",
    "Dataram",
   " Fujitsu",
    "G.Skill",
  "  GeIL",
   " HyperX",
  "  IBM",
  "  Infineon",
   " Kingston Technology",
   " Lenovo",
   " Micron Technology",
    "Mushkin",
   " Netlist",
    "PNY",
    "Rambus",
    "Ramtron International",
    "Rendition",
   " Renesas Technology",
    "Samsung Semiconductor",
    "Sandisk",
   " Sea Sonic",
   " SK Hynix",
   " Silicon Power",
    "Super Talent",
  "  Toshiba",
   " Transcend",
  "  TwinMOS",
    "Virtium",
    "Wilk Elektronik",
   " Winbond",
    "Wintec Industries Inc."

 };



            switch (correctItem)
            {
                case 0:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_Case);
                    break;
                case 1:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_CPU);
                    break;
                case 2:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_CPUCooler);
                    break;
                case 3:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_GPU);
                    break;
                case 4:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_Mainboard);
                    break;
                case 5:
                    Manufacturers_Listbox.Items.Clear();
                    Manufacturers_Listbox.Items.AddRange(Manufacturer_RAM);
                    break;
            }


        }
    }
}
