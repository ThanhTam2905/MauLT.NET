using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduCenterApp.Forms;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
        SetupEvents();
    }

    private void SetupEvents()
    {
        btnRoleAdmin.Click += (s, e) => LaunchMain("Quản trị viên");
        btnRoleTeacher.Click += (s, e) => LaunchMain("Giáo viên");
        btnRoleStudent.Click += (s, e) => LaunchMain("Học viên");
    }

    private void LaunchMain(string role)
    {
        this.Hide();
        using var main = new MainForm(role);
        main.ShowDialog();
        this.Show();
    }
}
