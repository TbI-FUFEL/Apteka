using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class Aptek : Form
    {
        public Aptek()
        {
            InitializeComponent();
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //создаём новый экземпляр класса Аптека
            AptekSet aptekSet = new AptekSet();
            //делаем ссылку на объект, который храниться в textBox-ax
            AptekSet.FirstName = textBoxFirstName.Text;
            AptekSet.Address = textBoxAddress.Text;
            AptekSet.Email = textBoxEmail.Text;
            AptekSet.Phone = textBoxPhone.Text;
            //добавляем в таблицу Aptek нового клиента aptek
            Program.аптека.Aptek.Add(Aptek);
            //сохраняем изменения в модели аптека (экземпляр которой был создан ранее)
            Program.аптека.SaveChanges();

        }
    }
}
