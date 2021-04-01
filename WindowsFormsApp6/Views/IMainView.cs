using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        List<Payment> Payment { set; }
        string NameText { get;}
        int LiterText { get; set; }
        string PayText { get; set; }
        DateTime TimeText { get; }

    }
}
