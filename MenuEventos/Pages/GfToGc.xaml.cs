namespace MenuEventos.Pages;

public partial class GfToGc : ContentPage
{
	public GfToGc()
	{
		InitializeComponent();
	}
    private void btnSubmitOnClicked(object sender, EventArgs e)
    {
        double entity = 0;
        double backup = 0;

        backup = double.Parse(etrInsert.Text);
        entity = (((double.Parse(etrInsert.Text)-32)*5)/9);

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