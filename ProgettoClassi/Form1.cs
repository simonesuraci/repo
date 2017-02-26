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
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderMonster(curMonsterIndex);
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
            renderMonster(curMonsterIndex);
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            if (curMonsterIndex == monsters.Count - 1) return;
            curMonsterIndex++;
            renderMonster(curMonsterIndex);
        }

        private void renderMonster(int monsterIndex)
        {
            enemyImg.Image = monsters[monsterIndex].image;
        }

    }
}
