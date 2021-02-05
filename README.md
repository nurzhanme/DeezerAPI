# DeezerAPI
Deezer API Client for dotNet 5.0

## DeezerAPI.Private
The Private Deezer API Implementaion

### Getting started

**Create API Client**
```csharp
PrivateAPI deezer = new PrivateAPI(arl);
```
> 'arl' Equals the Deezer arl Auth Cookie (From Browser DEV-Console)

**GetAlbumInfos**

```csharp
var albInfos = await deezer.GetAlbumInfos(ALB_ID);
```
> 'ALB_ID' Equals Deezer Album ID

**GetTrackInfos**

```csharp
var albInfos = await deezer.GetTrackInfos(TRACK_ID);
```
> 'TRACK_ID' Equals Deezer Track ID

Returned Data Structure for Track & Album:
```csharp
        /// <summary>
        /// Deezer SongID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Track Titel
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Artist
        /// </summary>
        public string artist { get; set; }

        /// <summary>
        /// Duration in Sec.
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        public string[] genre { get; set; }

        /// <summary>
        /// Remix Artist
        /// </summary>
        public string remixArtist { get; set; }

        /// <summary>
        /// Release Year
        /// </summary>
        public string year { get; set; }

        /// <summary>
        /// Release Date
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// Album Name
        /// </summary>
        public string album { get; set; }

        /// <summary>
        /// Artsts
        /// </summary>
        public string[] artists { get; set; }

        /// <summary>
        /// Album Art
        /// </summary>
        public string albumart { get; set; }

        /// <summary>
        /// ISRC ID
        /// </summary>
        public string isrc { get; set; }

        /// <summary>
        /// Track MD5 Hash
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// Track Media Version
        /// </summary>
        public string MediaVersion { get; set; }

        /// <summary>
        /// Track Quality
        /// </summary>
        public int Quality { get; set; }
```

## DeezerAPI.Public
The Official Deezer API Implementaion

### Getting started

**Create API Client**
```csharp
PublicAPI deezer = new PublicAPI();
```

**Query Deezer API**
```csharp
var data = await deezer.Search(
    new Query("Two Door Cinema Club", "What You Know", Type.Track));
```


## DeezerAPI.Mobile
The Mobile Deezer API Implementation

### Getting started

**Create Unauthenticated API Client**
```csharp
IUnauthenticatedMobileAPI deezer = new MobileAPI();
```

> An Unauthenticated Deezer API must call `await GenerateSID()` first!

**Create Authenticated API Client**
```csharp
IAuthenticatedMobileAPI deezer = new MobileAPI(arl);
```

### Get Track Infos
```csharp
var trackInfos = await deezer.GetTrack(SNG_ID);
```

### Get Tracks
```csharp
List<string> IDs = new List<string>(){ "111", "222", "333" };
var trackInfos = await deezer.GetTracks(IDs);
```

### Get Track Lyrics
```csharp
var trackLyrics = await deezer.GetTrackLyrics(SNG_ID);
```

### Get Album Infos
```csharp
var albInfos = await deezer.GetAlbum(ALB_ID);
```

### Get Playlist Infos
```csharp
var playlistInfos = await deezer.GetPlaylist(Playlist_ID);
```

## Build with dotNET 5.0 & VS 2019
