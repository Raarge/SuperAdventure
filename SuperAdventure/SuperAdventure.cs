using Engine;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            Location location = new Location(1, "Home", "This is your house.");
            
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperiance.Text = _player.ExperiancePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void btnNorth_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEast_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, System.EventArgs e)
        {

        }

        private void btnWest_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, System.EventArgs e)
        {

        }
    }
}
