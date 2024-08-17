/*
Nombre de la practica: RunS
Tema de Referencia: Componentes y Librerias
Objetivo: Desarrollar una aplicacón que permita inplementar componentes definidos por el usuario, y componentes
          integrados de .Net
Nombres: Adrián Ortíz Quistián
         Jaime Emnuel Quitián sánchez
Materia: Topicos Avanzados de Programacón
*/

//---------------- Librerias ----------------
//Seleción de librerias del sistema
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar las librerias para configuarar el joystick
using AForge;
using AForge.Controls;

//---------------- Código ----------------
namespace TAPU1_A2
{
    public partial class frmRunS : Form
    {
        //---------------- Variables globales ----------------
        //Creación de las variables globales
        //Inicio declaracion de clases para los Joysticks declarados en un inicio como variables
        Joystick joystick;
        Joystick joystick2;
        //Creación de una lista global para utilizarla en el seleccionado de los controles
        List<Joystick.DeviceInfo> dispositivosJoysticks = Joystick.GetAvailableDevices();
        //Creación la clase de tipo Random para asignarles velocidades aleatorias a los Personajes
        Random velocidad = new Random();
        DialogResult victoria = new DialogResult();
        System.Drawing.Point ubicacion= new System.Drawing.Point(1,331);
        System.Drawing.Point ubicacion2 = new System.Drawing.Point(1, 211);
        //---------------- Constructor ----------------
        public frmRunS()
        {
            InitializeComponent();
            //Decalaración de la propiedad DoubleBuffered para evitar el parpadeo del personaje durante su activación
            this.DoubleBuffered = true;

        }

        //---------------- Eventos ----------------

        //---------------- Evento Click ----------------
        //Declaración del evento click para asignar un Joystick al primer jugador
        private void frmRunS_Click(object sender, EventArgs e)
        {
            
            //Instansiación de un dialog result para preguntarle al usuario si ese es el control que desea asignar
            //para el primer jugador y conectarlo
            DialogResult conexion = new DialogResult();
            //Declaración del try y catch para atrapar errores en caso de presentarse 
            try
            {
                //Termino de la creación de la clase para el Joystick con el paramétro del combobox que guardá la ID
                //del joystick a conectar
                joystick = new Joystick(cbListasJoysticks.SelectedIndex);
                //Información que mostrará el Dialog Result como su texto, título, opciones e icono  
                conexion = MessageBox.Show("¿Quieres conectarte?", "Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Comparación de la respuesta dada por el usuario para activar o desactivar el timer del jugador 1
                if (conexion == DialogResult.Yes)
                {
                    //Si la respuesta es si entonces se activará el timer para la conexión del Joystick con el
                    //personaje
                    tmrJoyStick.Enabled = true;
                }
                else
                {
                    //Si la respuesta es no entonces no se activará el timer para la conexión del Joystick con el
                    //personaje
                    tmrJoyStick.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //En caso de no detectar un Joystick para la conexión  el catch mostrará un mensaje de error  
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //---------------- Evento SelectChangeComited ----------------

        //Declaración del evento SelectionChangeCommitted para asignar un Joystick al segundo jugador
        private void cbListas2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Instansiación de un dialog result para preguntarle al usuario si ese es el control que desea asignar
            //para el segundo jugador y conectarlo
            DialogResult conexion = new DialogResult();
            //Declaración del try y catch para atrapar errores en caso de presentarse
            try
            {

                //Termino de la creación de la clase para el Joystick con el paramétro del combobox que guardá la ID
                //del joystick a conectar
                joystick2 = new Joystick(cbListas2.SelectedIndex);
                //Información que mostrará el Dialog Result como su texto, título, opciones e icono
                conexion = MessageBox.Show("¿Quieres conectarte?", "Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Comparación de la respuesta dada por el usuario para activar o desactivar el timer del jugador 2
                if (conexion == DialogResult.Yes)
                {

                    //Si la respuesta es si entonces se activará el timer para la conexión del Joystick con el
                    //personaje
                    tmrJoystick2.Enabled = true;
                }
                else
                {
                    //Si la respuesta es no entonces no se activará el timer para la conexión del Joystick con el
                    //personaje
                    tmrJoystick2.Enabled = false;
                }
            }
            //En caso de no detectar un Joystick para la conexión  el catch mostrará un mensaje de error 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //---------------- Evento Load ----------------

        //Declaración del evento Load para cargar la lista de los controles que se mostrarán en los combobox 
        private void frmRunS_Load(object sender, EventArgs e)
        {
            
            //Creación de Foreach con los controles disponibles para el jugador 1
            foreach (Joystick.DeviceInfo joystick in dispositivosJoysticks)
            {
                cbListasJoysticks.Items.Add(string.Format("ID: {0}, Nombre: {1} ...", joystick.ID+1, joystick.Name));
            }
            //Creación de Foreach con los controles disponibles para el jugador 2
            foreach (Joystick.DeviceInfo joystick in dispositivosJoysticks)
            {
                cbListas2.Items.Add(string.Format("ID: {0}, Nombre: {1} ...", joystick.ID + 1, joystick.Name));
            }
        }

        //---------------- Joystick 1 ----------------

        //---------------- Evento Tick Para Joystik1 ----------------

        //Declaración del primer timer para el jugador 1 con las acciones de su control
        private void tmrJoyStick_Tick(object sender, EventArgs e)
        {
            //Declaración del try y catch para atrapar errores en caso de presentarse
            try
            {
                //Creación de una clase para guardar el estatus del joystick para guardarlo dentro de la
                //variable joystick
                Joystick.Status status = joystick.GetCurrentStatus();
                //Si se preciona el botón 2 se desactivará el timer que controla el movimiento del personaje  
                if (status.XAxis==1)
                {
                    //Declarar la variable para asignarle valores randoms para la velocidad que tendrá el personaje
                    int personaVelocidad = velocidad.Next(1, 10);
                    //Aumento de velocidad del personaje con los valores randoms declarados 
                    anmPersona.Left = anmPersona.Left + personaVelocidad;
                }
                //Si se preciona el botón 1 se activará el timer que controla el movimiento del personaje  
                if (status.XAxis == -1)
                {
                    //Declarar la variable para asignarle valores randoms para la velocidad que tendrá el personaje
                    int personaVelocidad = velocidad.Next(1, 10);
                    //Aumento de velocidad del personaje con los valores randoms declarados 
                    anmPersona.Left = anmPersona.Left - personaVelocidad;
                }
                //Si se preciona el botón 3 se activará un salto que después de un tiempo bajará simulando un salto
                //del personaje  
                if (status.YAxis==-1)
                {
                    tmrMovimiento.Enabled = true;
                }
                //Se utiliza la propiedad right para obtener la distancia en pixeles del borde derecho al izquierdo 
                //que se comparará con el tamaño de la ventana por medio de la propiedad ClientSize.Width 
                //para conocer su tamaño
                if (anmPersona.Right >= ClientSize.Width)
                {
                    anmPersona.Location = ubicacion;
                    anmPersona2.Location = ubicacion2;
                    //Se desactiva el timer del movimiento para activar el movimiento en reversa del personaje
                    victoria =MessageBox.Show("El ganador es el Jugador 1","Ganador",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (anmPersona.Right < 100)
                {
                    anmPersona.Location = ubicacion;
                }
            }
            //En caso de no detectar un Joystick para la conexión  el catch mostrará un mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //---------------- Evento Tick del Joystik 1 ----------------

        //Decalaración del evento para controlar el movimiento hacia adelante del personaje
        private void tmrMovimiento_Tick(object sender, EventArgs e)
        {
            anmPersona.Top -= 20;
            Thread.Sleep(80);
            anmPersona.Top += 20;
            tmrMovimiento.Stop();
        }

        //---------------- Joystick 2 ----------------

        //---------------- Evento Tick Para Joystik2 ----------------

        //Declaración del primer timer para el jugador 2 con las acciones de su control
        private void tmrJoystick2_Tick(object sender, EventArgs e)
        {
            //Declaración del try y catch para atrapar errores en caso de presentarse
            try
            {
                //Creación de una clase para guardar el estatus del joystick para guardarlo dentro de la
                //variable joystick
                Joystick.Status status = joystick2.GetCurrentStatus();
                //Si se preciona el botón 2 se desactivará el timer que controla el movimiento del personaje  
                if (status.XAxis == 1)
                {
                    //Declarar la variable para asignarle valores randoms para la velocidad que tendrá el personaje
                    int personaVelocidad = velocidad.Next(1, 10);
                    //Aumento de velocidad del personaje con los valores randoms declarados 
                    anmPersona2.Left = anmPersona2.Left + personaVelocidad;
                }
                //Si se preciona el botón 1 se activará el timer que controla el movimiento del personaje  
                if (status.XAxis == -1)
                {
                    //Declarar la variable para asignarle valores randoms para la velocidad que tendrá el personaje
                    int personaVelocidad = velocidad.Next(1, 10);
                    //Aumento de velocidad del personaje con los valores randoms declarados 
                    anmPersona2.Left = anmPersona2.Left - personaVelocidad;
                }
                //Si se preciona el botón 3 se activará un salto que después de un tiempo bajará simulando un salto
                //del personaje  
                if (status.YAxis == -1)
                {
                    tmrMovimiento.Enabled = true;
                }
                //Se utiliza la propiedad right para obtener la distancia en pixeles del borde derecho al izquierdo 
                //que se comparará con el tamaño de la ventana por medio de la propiedad ClientSize.Width 
                //para conocer su tamaño
                if (anmPersona.Right >= ClientSize.Width)
                {
                    anmPersona2.Location = ubicacion2;
                    anmPersona.Location = ubicacion;
                    //Se desactiva el timer del movimiento para activar el movimiento en reversa del personaje
                    victoria = MessageBox.Show("El ganador es el Jugador 2", "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                if (anmPersona2.Right < 100)
                {
                    anmPersona2.Location = ubicacion2;
                }
            }
            //En caso de no detectar un Joystick para la conexión  el catch mostrará un mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //---------------- Evento Tick del Joystik 2 ----------------
        //Decalaración del evento para controlar el movimiento hacia adelante del personaje
        private void tmrMovimientoP2_Tick(object sender, EventArgs e)
        {
            anmPersona2.Top -= 20;
            Thread.Sleep(80);
            anmPersona2.Top += 20;
            tmrMovimientoP2.Stop();
        }
    }
}