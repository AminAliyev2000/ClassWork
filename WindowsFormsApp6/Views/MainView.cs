using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get;set; }
        public List<Payment> Payment
        {
            set
            {
                DataListbox.DataSource = null;
                DataListbox.DataSource = value;
            }
        }
        public string NameText { get =>oilcombobox.SelectedIndex.ToString();}
        public string LiterText { get => Litrestxtbox.Text; set =>Litrestxtbox.Text=value; }
        public string PayText { get => PayPrielabel.Text; set => PayPrielabel.Text=value; }
        public DateTime TimeText { get => DateTime.Now;}
        
    }
}
