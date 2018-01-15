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

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiancePoints = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperiance.Text = _player.ExperiancePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        
    }
}
