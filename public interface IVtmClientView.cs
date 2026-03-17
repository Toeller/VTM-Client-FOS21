public interface IVtmClientView
{
    event Action StartzustandClicked;
    event Action BetriebClicked;
    event Action EntleerenClicked;

    string Status { set; }
}