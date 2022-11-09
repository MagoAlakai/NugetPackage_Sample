# README

## Create account on Nuget.org
Go to https://www.nuget.org/ and create an account, then enter your account to create an APIKEY at https://www.nuget.org/account/apikeys.
That ApiKey will be used later to push and publish the NugetPackage.

## Create a Class Library at VS

## Create a README.md file
Is mandatory to create a README.md file with at least one line : "# README"

## Create a LICENSE file
Is mandatory to create a LICENSE file with the following text:

> MIT License

> Copyright (c) 2022 magoalakai

> Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

> The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Fill the .csproj with the righ information
Check the sample source code from the NugetPackage HashiValt from kibblewhite: https://github.com/kibblewhite/HashiVaultCs/blob/main/Client/Client.csproj
You can also check the official documentation: https://learn.microsoft.com/en-us/nuget/create-packages/creating-a-package-dotnet-cli

It's important to add the LICENSE and README.md files into it:
> <ItemGroup>
    <None Include="LICENSE" Pack="true" PackagePath="" />
    <None Include="README.md" Pack="true" PackagePath="" />
</ItemGroup>

## Build the NugetProject of the release project
    dotnet build -c Release

    dotnet pack -c Release -o "[name-of-project /]/bin/Release/net7.0/publish"

In this case:

    dotnet pack -c Release -o "NugetPackage_Sample/bin/Release/net7.0/publish"

## Push and Publish the NugetProject
    dotnet nuget push "NugetPackage_Sample/bin/Release/net7.0/publish/NugetPackage_Sample.1.1.1.1.nupkg" -k [api-key-here /] -s https://api.nuget.org/v3/index.json

    dotnet nuget push NugetPackage_Sample/bin/Release/net7.0/publish/ NugetPackage_Sample.1.1.1.1.nupkg" -k oy2jo2mo6jo2kozcvk2abyaz3bgtoeaezduyverqz6gme4  -s https://api.nuget.org/v3/index.json
