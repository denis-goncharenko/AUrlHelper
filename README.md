# AUrlHelper

The AUrlHelper is a [Nuget Package](https://www.nuget.org/packages/AUrlHelper) for getting file name or folder name from the url when you work with cloud storages like S3, Dropbox, GoogleDrive or Azure Blob Storage.

## Usages

#### Add Using

``` csharp
    using AUrlHelper;
````

### Examples

#### Get Folder Name

``` csharp
    var path = "https://test.com/assets/images/test.png"
    AUrlHelper.GetFolderName(path);
    // return "images" 
```
or
``` csharp
    var path = "https://test.com/assets/images/test.png"
    path.GetFolderName(path);
    //return "images"
```

#### Get File Name

``` csharp
     var path = "https://test.com/assets/images/test.png"
    AUrlHelper.GetFileName(path);
    // return "test.png" 
```
or
``` csharp
    var path = "https://test.com/assets/images/test.png"
    path.GetFileName(path);
    //return "test.png"
```

#### Get File Name Without Extension

``` csharp
     var path = "https://test.com/assets/images/test.png"
    AUrlHelper.GetFileNameWithoutExtension(path);
    // return "test" 
```
or
``` csharp
    var path = "https://test.com/assets/images/test.png"
    path.GetFileNameWithoutExtension(path);
    //return "test"
```