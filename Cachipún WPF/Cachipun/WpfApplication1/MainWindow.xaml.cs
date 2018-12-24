using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cachipun;

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Personaje p1;
        Personaje p2;
        int seleccionP1 = 0;
        int seleccionP2 = 0;
        int turno = 0;
        int muerte_s = 0;
        System.Media.SoundPlayer musica = new System.Media.SoundPlayer();


        public MainWindow()
        {
            InitializeComponent();
            btnCerrar.Visibility = Visibility.Hidden;
            btnRevancha.Visibility = Visibility.Hidden;
            btnPapel.Visibility = Visibility.Hidden;
            btnPiedra.Visibility = Visibility.Hidden;
            btnTijera.Visibility = Visibility.Hidden;
            
            txtCantTurnos.IsEnabled = true;
            musica.SoundLocation = @"..\\..\\sonido\\turno.wav";
            musica.PlayLooping();

        }

        private void txtCantTurnos_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void btnComenzar_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    if (txtCantTurnos.Text.Equals("1") || txtCantTurnos.Text.Equals("3") || txtCantTurnos.Text.Equals("5") || txtCantTurnos.Text.Equals("9") || txtCantTurnos.Text.Equals("13") || txtCantTurnos.Text.Equals("15"))
                    {
                        

                        turno = 1;
                        //turno++;
                        lblTurno.Content = turno;

                        imgP1.Visibility = Visibility.Visible;
                        imgP2.Visibility = Visibility.Visible;

                        btnComenzar.Visibility = Visibility.Hidden;
                        btnCerrar.Visibility = Visibility.Hidden;
                        btnRevancha.Visibility = Visibility.Hidden;
                        btnPapel.Visibility = Visibility.Visible;
                        btnPiedra.Visibility = Visibility.Visible;
                        btnTijera.Visibility = Visibility.Visible;

                        txtCantTurnos.IsEnabled = false;

                        p1 = new Personaje();
                        p2 = new Personaje();

                        lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                        lblTurnosGanadosP2.Content = p2.Turnos_ganados;

                        musica.SoundLocation = @"..\\..\\sonido\\juego.wav";
                        musica.PlayLooping();
                        
                        //poner musica pelea

                    }
                    else
                    {
                        throw new ArgumentException("numero de rondas invalido! 1,3,5,9,13,15?");
                    }
                }

                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message);
                    txtCantTurnos.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }

        private void btnPiedra_Click(object sender, RoutedEventArgs e)
        {
            //poner imagen de la piedra
            seleccionP1 = 1;
            imgP1.Source = new BitmapImage(new Uri("/img/piedra.jpg", UriKind.Relative));
            //turno++;
            if (muerte_s == 0)
            {
                FinalizarTurno();           
            }
            if (muerte_s == 1)
            {
                MuerteSubita();
            }

            
        }

        private void btnPapel_Click(object sender, RoutedEventArgs e)
        {
            //poner imagen
            seleccionP1 = 2;
            //turno++;
            imgP1.Source = new BitmapImage(new Uri("/img/papel.jpg", UriKind.Relative));
            if (muerte_s == 0)
            {
                FinalizarTurno();
            }
            if (muerte_s == 1)
            {
                MuerteSubita();
            }
            //lblTurno.Content = turno + 1;
        }

        private void btnTijera_Click(object sender, RoutedEventArgs e)
        {
            //poner imagen
            seleccionP1 = 3;
            imgP1.Source = new BitmapImage(new Uri("/img/tijera.jpg", UriKind.Relative));
           // turno++;
            if (muerte_s == 0)
            {
                FinalizarTurno();
            }
            if (muerte_s == 1)
            {
                MuerteSubita();
            }
           // lblTurno.Content = turno + 1;
        }

        private void SeleccionCPU()
        {
            seleccionP2 = 0;
            Random rd = new Random();
            seleccionP2=rd.Next(1, 4);

            if (seleccionP2 == 1) { imgP2.Source = new BitmapImage(new Uri("/img/piedra.jpg", UriKind.Relative)); }
            if (seleccionP2 == 2) { imgP2.Source = new BitmapImage(new Uri("/img/papel.jpg", UriKind.Relative)); }
            if (seleccionP2 == 3) { imgP2.Source = new BitmapImage(new Uri("/img/tijera.jpg", UriKind.Relative)); }

            //if(rd.Next(1, 4))


        }
        private void MuerteSubita()
        {

            txtCantTurnos.Text = "muerte subita";
                SeleccionCPU();

                switch (seleccionP1)
                {
                    case 1:
                        switch (seleccionP2)
                        {
                            case 1:
                                //empate
                                turno++;
                                break;
                            case 2:
                                p2.Turnos_ganados = p2.Turnos_ganados++;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            case 3:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    case 2:
                        switch (seleccionP2)
                        {
                            case 1:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            case 2:
                                //empate
                                turno++;
                                break;
                            case 3:
                                p2.Turnos_ganados++;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    case 3:
                        switch (seleccionP2)
                        {
                            case 1:
                                p2.Turnos_ganados++;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            case 2:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            case 3:
                                //empate
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    default:
                        break;

                }

                if (p1.Turnos_ganados > p2.Turnos_ganados)
                {
                    lblTurnosGanadosP1.Content = lblTurnosGanadosP1.Content + " | Ganador";
                    btnPapel.Visibility = Visibility.Hidden;
                    btnPiedra.Visibility = Visibility.Hidden;
                    btnTijera.Visibility = Visibility.Hidden;
                    btnCerrar.Visibility = Visibility.Visible;
                    btnRevancha.Visibility = Visibility.Visible;
                    txtCantTurnos.Text = "fin del juego";
                    if (btnComenzar.Visibility == Visibility.Hidden)
                    {
                        musica.SoundLocation = @"..\\..\\sonido\\p1win.wav";
                        musica.Play();
                    }
                }
                if (p1.Turnos_ganados < p2.Turnos_ganados)
                {
                    if (btnComenzar.Visibility == Visibility.Hidden)
                    {
                        musica.SoundLocation = @"..\\..\\sonido\\p2win.wav";
                        musica.Play();
                    }
                    lblTurnosGanadosP2.Content = lblTurnosGanadosP2.Content + " | Ganador";
                    btnPapel.Visibility = Visibility.Hidden;
                    btnPiedra.Visibility = Visibility.Hidden;
                    btnTijera.Visibility = Visibility.Hidden;
                    btnCerrar.Visibility = Visibility.Visible;
                    btnRevancha.Visibility = Visibility.Visible;
                    txtCantTurnos.Text = "fin del juego";
                }
                if (p1.Turnos_ganados == p2.Turnos_ganados)
                {
                    //muerte_s = 1;
                  //  MuerteSubita();
                   // muerte_s = 0;
                }

 
        }
        private void FinalizarTurno()
        {
            //if turnos > turnos maximos
            //if (int.Parse(txtCantTurnos.Text) == 1) { turno = 0; }
            //if (muerte_s == 1) { turno = 0; }
            if (turno < int.Parse(txtCantTurnos.Text))
            {
                lblTurno.Content = turno + 1;
                SeleccionCPU();

                switch (seleccionP1)
                {
                    case 1:
                        switch (seleccionP2)
                        {
                            case 1:
                                //empate
                                turno++;
                                break;
                            case 2:
                                p2.Turnos_ganados = p2.Turnos_ganados + 1;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            case 3:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    case 2:
                        switch (seleccionP2)
                        {
                            case 1:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            case 2:
                                //empate
                                turno++;
                                break;
                            case 3:
                                p2.Turnos_ganados++;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    case 3:
                        switch (seleccionP2)
                        {
                            case 1:
                                p2.Turnos_ganados++;
                                lblTurnosGanadosP2.Content = p2.Turnos_ganados;
                                turno++;
                                break;
                            case 2:
                                p1.Turnos_ganados++;
                                lblTurnosGanadosP1.Content = p1.Turnos_ganados;
                                turno++;
                                break;
                            case 3:
                                //empate
                                turno++;
                                break;
                            default:
                                break;

                        }
                        break;
                    default:
                        break;

                }
               

            }
            else
            {
                
                if (p1.Turnos_ganados > p2.Turnos_ganados)
                {
                    if (btnComenzar.Visibility == Visibility.Hidden)
                    {
                        musica.SoundLocation = @"..\\..\\sonido\\p1win.wav";
                        musica.Play();
                    }
                    
                    lblTurnosGanadosP1.Content = lblTurnosGanadosP1.Content+" | Ganador";
                    btnPapel.Visibility = Visibility.Hidden;
                    btnPiedra.Visibility = Visibility.Hidden;
                    btnTijera.Visibility = Visibility.Hidden;
                    btnCerrar.Visibility = Visibility.Visible;
                    btnRevancha.Visibility = Visibility.Visible;
                    txtCantTurnos.Text = "fin del juego";
                    
                }
                if (p1.Turnos_ganados < p2.Turnos_ganados)
                {
                    if (btnComenzar.Visibility == Visibility.Hidden)
                    {
                        musica.SoundLocation = @"..\\..\\sonido\\p2win.wav";
                        musica.Play();
                    }
                    lblTurnosGanadosP2.Content = lblTurnosGanadosP2.Content+" | Ganador";
                    btnPapel.Visibility = Visibility.Hidden;
                    btnPiedra.Visibility = Visibility.Hidden;
                    btnTijera.Visibility = Visibility.Hidden;
                    btnCerrar.Visibility = Visibility.Visible;
                    btnRevancha.Visibility = Visibility.Visible;
                    txtCantTurnos.Text = "fin del juego";
                }
                if (p1.Turnos_ganados == p2.Turnos_ganados)
                {
                    muerte_s = 1;

                    //MuerteSubita();
                }
                

                
                

            }
            
            
            
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRevancha_Click(object sender, RoutedEventArgs e)
        {
            btnComenzar.Visibility = Visibility.Visible;
            btnCerrar.Visibility = Visibility.Hidden;
            btnRevancha.Visibility = Visibility.Hidden;
            imgP1.Visibility = Visibility.Hidden;
            imgP2.Visibility = Visibility.Hidden;
            
            txtCantTurnos.Text = "";
            txtCantTurnos.IsEnabled = true;
            lblTurno.Content = "";
            lblTurnosGanadosP1.Content = "";
            lblTurnosGanadosP2.Content = "";

            musica.SoundLocation = @"..\\..\\sonido\\turno.wav";
            musica.PlayLooping();
            

        }


     }
}

