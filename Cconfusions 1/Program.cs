// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Color[] colors = new Color[] { Color.heart, Color.spade, Color.diamond, Color.clover };
Rank[] ranks = new[] { Rank.one, Rank.two, Rank.three, Rank.jack };
List<Card> cards = new List<Card>();
for (int i = 0; i < colors.Length; i++)
{
    for (int j = 0; j < ranks.Length; j++)
    {
        cards.Add(new Card(colors[i], ranks[j]));
    }
}
foreach (var item in cards)
{
    Console.WriteLine((item.color, item.rank));
}/*THE FUCK. A bracket made this print, it didn't print otherwise...
    item.color +" "+ item.rank this works
    two brackets works....
    item.color, item.rank      THis doesn't work
*/
class Card
{
    public Color color { get; init; }
    public Rank rank { get; init; }
    public Card(Color color, Rank rank)
    {
        this.color = color;
        this.rank = rank;
    }
    public bool isSymbol => rank == Rank.jack && rank == Rank.queen && rank == Rank.king && rank == Rank.ace;
    public bool isNumber => !isSymbol;
}
enum Color { heart, diamond, spade, clover }
enum Rank { one, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace }