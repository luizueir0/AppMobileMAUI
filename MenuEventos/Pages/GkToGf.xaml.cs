namespace MenuEventos.Pages;

public partial class GkToGf : ContentPage
{
	public GkToGf()
	{
		InitializeComponent();
	}
    private void btnSubmitOnClicked(object sender, EventArgs e)
    {
        double entity = 0;
        double backup = 0;

        backup = double.Parse(etrInsert.Text);
        entity = (((double.Parse(etrInsert.Text) - 273.15) * 9)/5) + 32;

        etrAnswer.Text = entity.ToString();

        DisplayAlert("RESULTADO",
            $"{backup} convertido em fahrenreit resulta em: {entity}",
            "Ok");
    }
    private void btnCleanOnClicked(object sender, EventArgs e)
    {
        etrInsert.Text = "";
        etrAnswer.Text = "";
    }

}