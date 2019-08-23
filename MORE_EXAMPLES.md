# More examples

**This document only shows examples of how to use the `PlotlyChart` type. To see complete examples of how to generate an image from a `PlotlyChart` object, see the main README.**

## Bar
![Imgur](https://i.imgur.com/kza2Dlwh.png)

```cs
PlotlyChart myChart = new PlotlyChart
{
    Figure = new Figure
    {
        Data = new ArrayList
        { 
            new BarTrace
            {
                X = new ArrayList
                {
                    1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012
                },
                Y = new ArrayList
                {
                    219, 146, 112, 127, 124, 180, 236, 207, 236, 263, 350, 430, 474, 526, 488, 537, 500, 439
                },
                Name = "Rest of world",
                Marker = new Marker { Color = "rgb(55, 83, 109)" }
            },
            new BarTrace
            {
                X = new ArrayList
                {
                    1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012
                },
                Y = new ArrayList
                {
                    16, 13, 10, 11, 28, 37, 43, 55, 56, 88, 105, 156, 270, 299, 340, 403, 549, 499
                },
                Name = "China",
                Marker = new Marker { Color = "rgb(26, 118, 255)" }
            }
        },
        Layout = new Layout
        {
            Title = new Title
            {
                Text = "US Export of Plastic Scrap"
            },
            XAxis = new Axis
            {
                TickFont = new Font
                {
                    Size = 14,
                    Color = "rgb(107, 107, 107)"
                }
            },
            YAxis = new Axis
            {
                Title = new Title
                {
                    Text = "USD (millions)",
                    Font = new Font
                    {
                        Size = 16,
                        Color = "rgb(107, 107, 107)"
                    }
                },
                TickFont = new Font
                {
                    Size = 14,
                    Color = "rgb(107, 107, 107)"
                }
            },
            ShowLegend = true,
            Legend = new Legend
            {
                X = 0,
                Y = 1.0,
                BgColor = "rgba(255, 255, 255, 0)",
                BorderColor = "rgba(255, 255, 255, 0)"
            },            
            BarMode = "group",
            BarGap = 0.15,
            BarGroupGap = 0.1
        }
    },
    Height = 1000,
    Width = 1000
};
```

## Contour
![Imgur](https://i.imgur.com/2leyBw5h.png)

```cs
PlotlyChart myChart = new PlotlyChart
{
    Figure = new Figure
    {
        Data = new ArrayList
        { 
            new ContourTrace
            {
                Z = new ArrayList
                {
                    new ArrayList { 10, 10.625, 12.5, 15.625, 20 },
                    new ArrayList { 5.625, 6.25, 8.125, 11.25, 15.625 },
                    new ArrayList { 2.5, 3.125, 5, 8.125, 12.5 },
                    new ArrayList { 0.625, 1.25, 3.125, 6.25, 10.625 },
                    new ArrayList { 0, 0.625, 2.5, 5.625, 10 }
                },
                ColorBar = new BarDto
                {
                    Ticks = "outside",
                    DTick = 1,
                    TickWidth = 2,
                    TickLen = 10,
                    TickColor = "grey",
                    TickFont = new Font { Size = 15 },
                    XPad = 50
                }
            }
        },
        Layout = new Layout { ShowLegend = false }
    },
    Height = 1000,
    Width = 1000
};
```

## Heatmap
![Imgur](https://i.imgur.com/UfAMO1lh.png)

```cs
Figure = new Figure
{
    Data = new ArrayList
    { 
        new HeatmapTrace
        {
            Z = new ArrayList
            {
                new ArrayList
                {
                    1, 20, 30, 50, 1
                },
                new ArrayList
                {
                    20, 1, 60, 80, 30
                },
                new ArrayList
                {
                    30, 60, 1, -10, 20
                }
            },
            X = new ArrayList { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
            Y = new ArrayList { "Morning", "Afternoon", "Evening" }
        }
    }
},
Height = 1000,
Width = 1000
```

## Pie
![Imgur](https://i.imgur.com/pgPu4J8h.png)

```cs
PlotlyChart myChart = new PlotlyChart
{
    Figure = new Figure
    {
        Data = new ArrayList
        { 
            new PieTrace
            {
                Values = new ArrayList { 16, 15, 12, 6, 5, 4, 42 },
                Labels = new ArrayList { "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                Domain = new Domain { Column = 0 },
                Name = "GHG Emissions",
                HoverInfo = "label+percent+name",
                Hole = .4
            },
            new PieTrace
            {
                Values = new ArrayList { 27, 11, 25, 8, 1, 3, 25 },
                Labels = new ArrayList { "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                Text = "CO2",
                TextPosition = "inside",
                Domain = new Domain { Column = 1 },
                Name = "GHG Emissions",
                HoverInfo = "label+percent+name",
                Hole = .4
            }
        },
        Layout = new Layout
        {
            Title = new Title { Text = "Global Emissions 1990-2011" },
            Annotations = new List<Annotation>
            {
                new Annotation
                {
                    Font = new Font { Size = 20 },
                    ShowArrow = false,
                    Text = "GHG",
                    X = 0.17,
                    Y = 0.5
                },
                new Annotation
                {
                    Font = new Font { Size = 20 },
                    ShowArrow = false,
                    Text = "CO2",
                    X = 0.82,
                    Y = 0.5
                }
            },
            ShowLegend = false,
            Grid = new Grid
            {
                Rows = 1,
                Columns = 2
            }
        }
    },
    Height = 1000,
    Width = 1000
};
```

