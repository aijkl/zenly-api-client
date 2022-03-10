# Zenly Widgets Client  
####  ZenlyのAPIからフレンドの位置情報を取得する  
```csharp
var zenlyApiClient = new ZenlyAPIClient(token:"s-sample-sample-sample-sample");//token
var userLocation = await zenlyApiClient.WidgetClient.FetchLocation(userId:"u-t0B0P4ub1FUR2pZc2YyvxU0LiVsFuHgB");//user id
Console.WriteLine(userLocation.Latitude);//緯度
Console.WriteLine(userLocation.Longitude);//経度
```

### パケットキャプチャー  
https://www.telerik.com/forums/https-on-ios15  
↑を使用してiOSのWidlgetsをパケットキャプチャする  
![スクリーンショット 2022-03-10 235243](https://user-images.githubusercontent.com/51302983/157687708-82a39d3d-06c6-4453-a046-22df0ef2ca9a.jpg)

![スクリーンショット 2022-03-10 234841](https://user-images.githubusercontent.com/51302983/157686922-cefbc460-dcce-408f-96cf-65cb6467dfee.jpg)  
<img width="325" alt="d55302-13-330860-0" src="https://user-images.githubusercontent.com/51302983/157686653-64234251-a65e-4205-82aa-c0c5d29a4069.png">
