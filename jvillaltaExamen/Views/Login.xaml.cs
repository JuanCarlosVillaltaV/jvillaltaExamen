namespace jvillaltaExamen.Views;

public partial class Login : ContentPage
{

    // Arreglo con los datos quemados
    private readonly string[,]
         users = new string[,]
    {
        { "estudiante", "moviles" },
        { "uisrael", "2024" }



    };

    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        if (ValidateLogin(usuario, contraseña))
        {
            ResultLabel.Text = "¡Login exitoso!";

            // Mensaje de bienvenida
            DisplayAlert("Bienvenido", $"Hola, {usuario}!", "Cerrar");

            // Navegar a la página Registro pasando el usuario
            Navigation.PushAsync(new Views.Registro(usuario));
        }

        else
        {
            ResultLabel.Text = "Usuario o contraseña incorrectos.";
        }
        }



        private bool ValidateLogin(string usuario, string contraseña)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == usuario && users[i, 1] == contraseña)
                {
                    return true;
                }
            }
            return false;

        }
    }



   