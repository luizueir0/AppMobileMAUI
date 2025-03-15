namespace MenuEventos.Pages;

public partial class MetToCent : ContentPage
{
	public MetToCent()
	{
		InitializeComponent();
	}
    private void btnSubmitOnClicked(object sender, EventArgs e)
    {
        int entity = 0;
        int backup = 0;

        backup = int.Parse(etrInsert.Text);
        entity = int.Parse(etrInsert.Text)*100;

        etrAnswer.Text = entity.ToString();

        DisplayAlert("RESULTADO",
            $"{backup} convertido em centimetros resulta em: {entity}",
            "Ok");
    }
    private void btnCleanOnClicked(object sender, EventArgs e)
    {
        etrInsert.Text = "";
        etrAnswer.Text = "";
    }

}