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
            catch (Amazon.Lambda.Model.ResourceNotFoundException)
            {
                return false;
            }
        }
    }
}
