# aspnetidentitysharecoreand4.8
Example project sharing cookies between ASP.NET 6 and ASP.NET Framework 4.8

This is related to my stackoverflow question https://stackoverflow.com/questions/76346772/asp-net-identity-cookie-compatibility-between-net-core-and-net

Code here based on https://stackoverflow.com/questions/76346772/asp-net-identity-cookie-compatibility-between-net-core-and-net

This app appears to be working apart from when it goes over a single cookie size, the chunking cookie manager creates more than one cookie and the .NET 4.8 app doesnt think it is logged in.

I also want to review it shortly for best practices.

Any comments welcome.
