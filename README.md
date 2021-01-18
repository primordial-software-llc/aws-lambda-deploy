# Aws Lambda Deploy

Infrastructure as code project to create lambda functions, schedules and assign permissions. **Functions will be deleted if they already exist.**

 - Deploy multiple instances of a function
 - Deploy function to multiple regions

# Nuget Deploy

## Set Nuget Package Creation on Build

    Right-Click AwsTools -> Properties -> Package -> Generate NuGet package on build

## Increment version in Visual Studio

    Right-Click AwsTools -> Properties -> Package -> Package Version

## Build

    \projects\aws-lambda-deploy\AwsLambdaDeploy>dotnet build --configuration release

## Deploy

    \projects\aws-lambda-deploy\AwsLambdaDeploy\bin\release>nuget push AwsLambdaDeploy.1.0.0.nupkg -src https://nuget.org/

*`pack` isn't required, because a nuget package is created on build*
