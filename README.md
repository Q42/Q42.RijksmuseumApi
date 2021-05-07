Q42.RijksmuseumApi [Archived]
=========

Open source library for communication with the Rijksmuseum API.
This library covers all the Rijksmuseum API calls. Search the collection, get detailed information and image tiles for object. Calendar events, RijksStudio user sets etc.

This Portable Library is compatible with: .Net45, Windows 8 and Windows Phone 8
Download directly from NuGet [Q42.RijksmuseumApi on NuGet](https://nuget.org/packages/Q42.RijksmuseumApi).

## How to use?
Some basic usage examples

### RijksClient
Before you can communicate with the Rijksmuseum API, you need to have an API key and use this API key to initialize a new RijksClient.
[Request your API key here](http://rijksmuseum.github.io/)

	IRijksClient _client = new RijksClient("YOUR_API_KEY");
	
### Search the collection

	var search = new CollectionSearchRequest();
 	search.SearchQuery = "sinterklaas";
	
	var searchResult = await _client.GetCollection(search);
	
Get detailed information about an object in the collection.
	
	var objectDetails = await _client.GetCollectionDetails("sk-c-5");
	
## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [Q42.RijksmuseumApi on NuGet](https://nuget.org/packages/Q42.RijksmuseumApi).

## Credits
This library is made possible by contributions from:
* [Michiel Post](http://www.michielpost.nl) ([@michielpostnl](http://twitter.com/michielpostnl)) - core contributor
* [Q42](http://www.q42.nl) ([@q42](http://twitter.com/q42))

### Open Source Project Credits

* Newtonsoft.Json is used for object serialization

## License

Q42.RijksmuseumApi is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [license.txt](https://github.com/Q42/Q42.RijksmuseumApi/blob/master/LICENSE.txt) for more information.

## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

## More info about the Rijksmuseum API
* [Rijksmuseum API](https://www.rijksmuseum.nl/en/api)
* [Documentation on GitHub](http://rijksmuseum.github.io/)
* [JavaScript samples](http://rijksmuseum.github.io/demos/)

