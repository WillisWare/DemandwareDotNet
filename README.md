# DemandwareDotNet
A C# wrapper library around the Demandware OCAPI service for native integrations in .NET projects.

## Configuration
A custom configuration section defines the configuration of the Demandware endpoints and credentials. An example follows:

    <configSections>
        <section name="ocapiConfig" type="Net.Demandware.Ocapi.Configuration.OcapiConfigurationSection" allowLocation="true" allowDefinition="Everywhere" />
    </configSections>
    <ocapiConfig>
        <credentials clientId="99999999-9999-aaaa-bbbb-999999999999" password="abcdefg1234567890xyz">
            <oauthPath url="https://account.demandware.com/dw/oauth2/access_token" />
        </credentials>
        <dataApi url="https://development-web-newbalance.demandware.net/s/site/dw/data/v16_3/" />
        <shopApi url="https://development-web-newbalance.demandware.net/s/site/dw/shop/v16_3/" />
    </ocapiConfig>
