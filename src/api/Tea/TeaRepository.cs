namespace api;

public class TeaRepository 
{
    private static readonly Tea[] teas = new[]
    {
        new Tea(
            "Stubb", 
            "https://white2tea.com/products/2023-stubb-minis"),
        new Tea(
            "Reading Room", 
            "https://white2tea.com/products/2023-reading-room-mini"),
    };

    internal IEnumerable<Tea> Get()
    {
        return teas;
    }
}
