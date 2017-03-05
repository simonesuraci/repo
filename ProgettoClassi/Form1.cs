using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoClassi;
using System.Collections.Generic;

namespace ProgettoClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserializer.deserializeMonster();
            listView1.Items.Add(new ListViewItem("prova"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderMonster(monsters[curMonsterIndex]);
            renderMonster(monsters[0], false);
        }

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }

        private int curMonsterIndex = 0;
        private void prevButt_Click(object sender, EventArgs e)
        {
            if (curMonsterIndex == 0) return;
            curMonsterIndex--;
            renderMonster(monsters[curMonsterIndex]);
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            if (curMonsterIndex == monsters.Count - 1) return;
            curMonsterIndex++;
            renderMonster(monsters[curMonsterIndex]);
        }

        private void renderMonster(Monster m, bool isPlayer = true)
        {
            if (isPlayer)
            {
                pNameLbl.Text = m.name;
                pHpLbl.Text = m.status;
                pHpBar.Maximum = m.maxHp;
                pHpBar.Value = m.curHp;
                pPicture.Image = m.image;
            }
            else
            {
                eNameLbl.Text = m.name;
                eHpLbl.Text = m.status;
                eHpBar.Maximum = m.maxHp;
                eHpBar.Value = m.curHp;
                ePicture.Image = m.image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logs.Items.Add("Tizio ha attaccato caio");
            Monster m = monsters[curMonsterIndex];
            m.curHp -= 20;
            renderMonster(m);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
