using System;
using System.Windows.Forms;
using EduCenterApp.Database;
using EduCenterApp.Forms;

namespace EduCenterApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            // Initialize SQLite Database and sample data
            DatabaseHelper.InitializeDatabase();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khởi tạo cơ sở dữ liệu SQLite: {ex.Message}", "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Application.Run(new WelcomeForm());
    }    
}
