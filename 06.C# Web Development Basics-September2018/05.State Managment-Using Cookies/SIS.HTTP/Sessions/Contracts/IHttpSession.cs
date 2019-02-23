namespace SIS.HTTP.Sessions.Contracts
{
    public interface IHttpSession
    {
        string Id { get; }

        object GetParameter(string name);

        bool ContainsParameter(string name, object parameter);

        void AddParameter(string name, object parameter);

        void ClearParameters();
    }
}
