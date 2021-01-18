using Amazon.Lambda;

namespace AwsLambdaDeploy
{
    public class LambdaFunctionExists
    {
        public bool FunctionExists(AmazonLambdaClient client, string functionName)
        {
            try
            {
                client.GetFunctionAsync(functionName).Wait();
                return true;
            }
            catch (System.AggregateException aggregateException)
            {
                if (aggregateException.InnerException != null &&
                    aggregateException.InnerException.GetType() == typeof(Amazon.Lambda.Model.ResourceNotFoundException))
                {
                    return false;
                }
                throw;
            }
        }
    }
}
