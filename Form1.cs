using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Avia
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Port=5432;Database=avia;User Id=weberxks; Password=yarik_3105";

        private string passengerName;
        private string ticketNumber;

        public Form1()
        {
            InitializeComponent();
            buttonGetSeatInfo.Click += new EventHandler(buttonGetSeatInfo_Click);
            exitButton.Click += new EventHandler(exitButton_Click); 
        }

        public Form1(DataTable flightInfo, string passengerName, string ticketNumber)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("plane.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.passengerName = passengerName;
            this.ticketNumber = ticketNumber;

            labelPassengerName.Text = "Пассажир: " + passengerName;
            labelTicketNumber.Text = "Номер билета: " + ticketNumber;

            dataGridView1.DataSource = flightInfo;

            buttonGetSeatInfo.Click += new EventHandler(buttonGetSeatInfo_Click);
            exitButton.Click += new EventHandler(exitButton_Click); 
        }

        private void buttonGetSeatInfo_Click(object sender, EventArgs e)
        {
            DataTable seatInfo = GetSeatInfoForPassenger(ticketNumber);

            if (seatInfo != null && seatInfo.Rows.Count > 0)
            {
                dataGridView2.DataSource = seatInfo;
            }
            else
            {
                MessageBox.Show("Данные о месте сидения не найдены.");
            }
        }

        private DataTable GetSeatInfoForPassenger(string ticketNumber)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = sqlConnection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT 
                            s.seat_no AS Номер_места,
                            s.fare_conditions AS Класс,
                            f.flight_no AS Номер_рейса
                        FROM 
                            bookings.tickets t
                        JOIN 
                            bookings.ticket_flights tf ON t.ticket_no = tf.ticket_no
                        JOIN 
                            bookings.flights f ON tf.flight_id = f.flight_id
                        JOIN 
                            bookings.boarding_passes bp ON tf.ticket_no = bp.ticket_no AND tf.flight_id = bp.flight_id
                        JOIN 
                            bookings.seats s ON bp.seat_no = s.seat_no AND f.aircraft_code = s.aircraft_code
                        WHERE 
                            t.ticket_no = @ticketNo;";

                    command.Parameters.AddWithValue("@ticketNo", ticketNumber);

                    using (NpgsqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable data = new DataTable();
                            data.Load(dataReader);
                            return data;
                        }
                    }
                }
            }
            return null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}