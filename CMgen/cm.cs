using System;
using System.Windows.Forms;

namespace CMgen
{
    public struct stage
    {
        public ushort id, time;
        public bool timer, final, blue, green, red;
    }

    public partial class program : Form
    {
        stage[] stages = new stage[0];

        public program()
        {
            InitializeComponent();
        }

        private void addstg(object sender, EventArgs e)
        {
            Array.Resize(ref stages, stages.Length + 1);
            stagelist.Items.Add("Stage " + stages.Length);
            if (stages.Length > 0) clear.Enabled = true;
        }

        private void selectstg(object sender, EventArgs e)
        {
            id.Enabled = true;
            timeBool.Enabled = true;
            time.Enabled = true;
            final.Enabled = true;
            goal_b.Enabled = true;
            goal_g.Enabled = true;
            goal_r.Enabled = true;
            remstage.Enabled = true;
            try
            {
                time.Value = stages[stagelist.SelectedIndex].time/60;
                timeBool.Checked = stages[stagelist.SelectedIndex].timer;
                time.Enabled = stages[stagelist.SelectedIndex].timer;
                final.Enabled = stages[stagelist.SelectedIndex].final;
                if (stages[stagelist.SelectedIndex].id > 32767)
                { id.Value = stages[stagelist.SelectedIndex].id - 65535; }
                else { id.Value = stages[stagelist.SelectedIndex].id; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void clearstg(object sender, EventArgs e)
        {
            stages = new stage[0];
            stagelist.Items.Clear();
            clear.Enabled = false;
        }

        private void updatestgtime(object sender, EventArgs e)
        {
            stages[stagelist.SelectedIndex].time = Convert.ToUInt16(time.Value*60);
        }

        private void updatestgid(object sender, EventArgs e)
        {
            if (id.Value < 0)
            stages[stagelist.SelectedIndex].id = Convert.ToUInt16(id.Value + 65535);
            else
            stages[stagelist.SelectedIndex].id = Convert.ToUInt16(id.Value);
        }

        private void timeToggle(object sender, EventArgs e)
        {
            stages[stagelist.SelectedIndex].timer = timeBool.Checked;
        }

        private void updatestgtimer(object sender, EventArgs e)
        {
            time.Enabled = timeBool.Checked;
        }

        private void delstage(object sender, EventArgs e)
        {
            stagelist.Items.RemoveAt(stagelist.SelectedIndex);
        }
    }
}
