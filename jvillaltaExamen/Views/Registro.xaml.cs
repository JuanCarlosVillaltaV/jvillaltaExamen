namespace jvillaltaExamen.Views;

public partial class Registro : ContentPage
{
    //Variables globales
    string user_global = "";

    public Registro()
    {
        InitializeComponent();
    }
   

    public Registro(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO" + usuario;
        user_global = usuario;
    }

    private void OnMontoCompleted(object sender, EventArgs e)
    {
        
        if (decimal.TryParse(txtMonto.Text, out decimal montoInicial))
        {
            
            if (montoInicial > 2500)
            {
                DisplayAlert("Error", "El monto no puede superar los 2500.", "OK");
                txtMonto.Text = string.Empty; // Limpiar el campo
            }
        }
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        
        const decimal costoCurso = 1500m;

        
        if (decimal.TryParse(txtMonto.Text, out decimal montoInicial))
        {
            
            decimal saldoRestante = costoCurso - montoInicial;

            
            decimal interes = costoCurso * 0.04m;

            
            decimal cuotaTotal = (saldoRestante / 4) + interes;

           
            DisplayAlert("Resultados", $"Monto inicial: {montoInicial:C}\n" +
                                        $"Saldo restante: {saldoRestante:C}\n" +
                                        $"Cuota total (4 cuotas): {cuotaTotal:C}", "OK");
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingresa un monto válido.", "OK");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}