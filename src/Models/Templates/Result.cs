namespace IfaceMainApi.Models.Templates
{
    public class Result<T>
    {
        public string? ErrorMessage { get; set; }
        public T? Value { get; set; }

        public static Result<T> Success(T value) => new() { Value = value };

        public static Result<T> Error(string message) => new() { ErrorMessage = message };

        public bool HasError()
        { 
            return !string.IsNullOrEmpty(ErrorMessage); 
        }

        private Result() { }

        
    }
}
