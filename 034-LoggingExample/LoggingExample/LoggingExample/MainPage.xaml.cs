using System;
using System.Diagnostics;
using System.Threading;

namespace LoggingExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        EventLogEntryType SelectParametre()
        {
            switch(Pik.SelectedItem.ToString())
            {
                case "Information": return EventLogEntryType.Information;
                case "Warning": return EventLogEntryType.Warning;
                case "Error": return EventLogEntryType.Error;
            }
            return EventLogEntryType.Information;
        }
        private void btn_Create_Clicked(object sender, EventArgs e)
        {
            try
            {
                string SourceName = txt_SourceName.Text;
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(txt_SourceName.Text, "Application");
                    lbl_msg.Text = "Event Source Created successfully";
                }
                EventLog.WriteEntry(txt_SourceName.Text, txt_Msg.Text, SelectParametre());
                lbl_msg.Text += "\nEvent Write to log";
            }
            catch (Exception ex)
            {
                lbl_msg.Text += "\n" + ex.Message;
            }
        }
    }

}
