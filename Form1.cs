using System;
using System.Windows.Forms;
using ReactiveMarbles.ObservableEvents;
namespace ObservableEventsDevexpressRepro;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        textEdit1.Events().KeyDown.Subscribe(_ => Console.WriteLine("KeyDown"));
    }
   
}