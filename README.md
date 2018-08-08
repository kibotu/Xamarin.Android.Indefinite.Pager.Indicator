
# Xamarin.Android.Indefinite.Pager.Indicator [![Build Status](https://app.bitrise.io/app/5dc870c99051a520/status.svg?token=FdGseowbt-2lw94VPDdGnQ&branch=master)](https://app.bitrise.io/app/5dc870c99051a520) [![BuildVersion](https://buildstats.info/nuget/Xamarin.Android.Indefinite.Pager.Indicator)](https://www.nuget.org/packages/Xamarin.Android.Indefinite.Pager.Indicator/)

A lightweight, plug-and-play indefinite pager indicator for RecyclerViews &amp; ViewPagers.

![GIF Preview](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/raw/master/readme_assets/preview.gif)

Port of https://github.com/rbro112/Android-Indefinite-Pager-Indicator to Xamarin.

## How to use

Have a look at [README.md](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/README.md)

## How to install

### Android

Add [Xamarin.Android.Indefinite.Pager.Indicator](https://www.nuget.org/packages/Xamarin.Android.Indefinite.Pager.Indicator)

        PM> Install-Package Xamarin.Android.Indefinite.Pager.Indicator -Version 1.0.9.2


## Getting Started

Attaching the indicator to a RecyclerView or Viewpager takes only one line of code. After this, the Indefinite Pager Indicator will handle everything else.

### RecyclerView

1. Add the IndefinitePagerIndicator view to your XML file

```xml
<Com.Rbrooks.Indefinitepagerindicator.IndefinitePagerIndicator
        android:id="@+id/recyclerview_pager_indicator"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        ...
        />
```

2. Find the view in your activity, fragment, etc.

```java
findViewById(R.id.recyclerview_pager_indicator);
```

3. Attach the RecyclerView to your IndefinitePagerIndicator

```java
indefinitePagerIndicator.attachToRecyclerView(recyclerView);
```

That's it! The IndefinitePagerIndicator will handle updating as your RecyclerView does.

### ViewPager

1. Add the IndefinitePagerIndicator view to your XML file


```xml
<com.rbrooks.indefinitepagerindicator.IndefinitePagerIndicator
        android:id="@+id/viewpager_pager_indicator"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        ...
        />
```

2. Find the view in your activity, fragment, etc.

```java
findViewById(R.id.viewpager_pager_indicator);
```

3. Attach the ViewPager to your IndefinitePagerIndicator

```java
indefinitePagerIndicator.attachToViewPager(viewPager);
```

That's it! The IndefinitePagerIndicator will handle updating as your ViewPager does.

The position of the ViewPager can also be changed programmatically with `viewPager.setCurrentItem(position)` and the IndefinitePagerIndicator will update successfully.

## How to build

    msbuild Xamarin.Android.Indefinite.Pager.Indicator.sln /t:Xamarin.Android.Indefinite.Pager.Indicator /p:Configuration="Release" /p:BuildProjectReferences=false

## Customizing

To customize the IndefinitePagerIndicator, modify any of the following attributes in the XML code for your IndefinitePagerIndicator view.

| Attribute             | Explanation                                               | Default Value | Example Code                     |  Result  |
|-----------------------|-----------------------------------------------------------|---------------|----------------------------------|:--------:|
| dotRadius             | The radius of a dot indicator in DP.                      | 4dp           | `app:dotRadius="8dp"`            |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/dot_radius_sample.png "dotRadius")     |
| selectedDotRadius     | The radius of the currently selected dot indicator in DP. | 5.5dp         | `app:selectedDotRadius="6dp"`    |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/selected_dot_radius_sample.png "selectedDotRadius")     |
| dotColor              | The color of a dot indicator.                             | #e8e8e8       | `app:dotColor="#ff0000"`         |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/dot_color_sample.png "dotColor")     |
| selectedDotColor      | The color of the currently selected dot indicator.        | #ffffff       | `app:selectedDotColor="#ff0000"` |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/selected_dot_color_sample.png "selectedDotColor")     |
| dotSeparation         | The distance from edge to edge of each dot in DP.         | 10dp          | `app:dotSeparation="16dp"`       |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/dot_separation_sample.png "dotSeparation")     |
| dotCount              | The number of large visible dot indicators at any time.   | 5             | `app:dotCount="3"`               |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/dot_count_sample.png "dotCount")     |
| fadingDotCount        | The number of dot indicators that fade towards the edge.  | 1             | `app:fadingDotCount="2"`         |     ![Alt text](https://github.com/rbro112/Android-Indefinite-Pager-Indicator/blob/master/readme_assets/fading_dot_count_sample.png "fadingDotCount")     |
| supportRTL            | Adds support for RTL ViewPagers (Thanks @wching!)         | false         | `app:supportRTL="true"`          |     If current layout mode is RTL, indicator will move from right to left with scrolling. |

## Contributors

[Jan Rabe](jan.rabe@kibotu.net)

### License
<pre>
Copyright 2018 Jan Rabe

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
</pre>
