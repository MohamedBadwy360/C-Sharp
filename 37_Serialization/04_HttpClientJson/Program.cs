using System.Text.Json;

namespace _04_HttpClientJson
{
    internal class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            // HttpClient is a class in System.Net.Http namespace
            // HttpClient is used to send HTTP requests and receive HTTP responses from a URL
            // HttpClient is used to consume Web API in .NET applications
            // It is a modern alternative to WebClient and HttpWebRequest classes
            // It's prefered to decalre it as shared instance and reuse it for multiple requests to the same URL 
            // HttpClient is a disposable object and should be disposed when it is no longer needed so that underlying resources are released
            // You should use it inside a using block or call Dispose method to dispose it

            using (httpClient)
            {
                var url = "https://jsonplaceholder.typicode.com/todos";
                var todoesJsonResponse = await httpClient.GetStringAsync(url);

                List<Todo> todoes = JsonSerializer.Deserialize<List<Todo>>(todoesJsonResponse,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                foreach (var todo in todoes)
                {
                    Console.WriteLine(todo);
                }
            }
        }



        public class Todo
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }

            public override string ToString()
            {
                return $"\n [{Id} - UserId: {UserId}] -  {Title} {(Completed ? "completed" : "not completed")}";
            }
        }
    }
}
