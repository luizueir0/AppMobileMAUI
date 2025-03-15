namespace MenuEventos.Pages;

public partial class GkToGc : ContentPage
{
	public GkToGc()
	{
		InitializeComponent();
	}
    private void btnSubmitOnClicked(object sender, EventArgs e)
    {
        double entity = 0;
        double backup = 0;

        backup = double.Parse(etrInsert.Text);
        entity = double.Parse(etrInsert.Text) - 273.15;

        etrAnswer.Text = entity.ToString();

        DisplayAlert("RESULTADO",
            $"{backup} convertido em celcius resulta em: {entity}",
            "Ok");
    }
    private void btnCleanOnClicked(object sender, EventArgs e)
    {
        etrInsert.Text = "";
        etrAnswer.Text = "";
    }

}