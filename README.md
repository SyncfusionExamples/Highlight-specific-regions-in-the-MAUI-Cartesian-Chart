# Highlight-specific-regions-in-the-MAUI-Cartesian-Chart

This sample demonstrates how to highlight specific regions in the .NET MAUI Cartesian Chart control within a .NET MAUI application.

## Sample

```xaml
    <chart:SfCartesianChart>

        <chart:SfCartesianChart.Title>
            <Label Text="Monthly Temperature Patterns Throughout the Year" FontSize="17"
                   HorizontalTextAlignment="Center" FontAttributes="Bold"/>
        </chart:SfCartesianChart.Title>

        <chart:SfCartesianChart.XAxes>
            <chart:DateTimeAxis ShowMajorGridLines="False" Interval="2" 
                                Minimum="2024-01-01" Maximum="2024-12-31"
                                EdgeLabelsDrawingMode="Fit" EdgeLabelsVisibilityMode="Visible">

                <chart:DateTimeAxis.LabelStyle>
                    <chart:ChartAxisLabelStyle LabelFormat="MMM"/>
                </chart:DateTimeAxis.LabelStyle>

                <chart:DateTimeAxis.Title>
                    <chart:ChartAxisTitle Text="Months" FontSize="15" TextColor="Black"/>
                </chart:DateTimeAxis.Title>
            </chart:DateTimeAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis x:Name="YAxis" Maximum="32" Minimum="20" Interval="4" 
                                ShowMinorGridLines="False" EdgeLabelsDrawingMode="Fit"
                                ShowMajorGridLines="False" PlotOffsetEnd="10">

                <chart:NumericalAxis.PlotBands>
                    <chart:NumericalPlotBandCollection>
                        <chart:NumericalPlotBand Start="22" End="22" Stroke="#B300E190"
                                                 StrokeWidth="2" Text="Low Temperature">

                            <chart:NumericalPlotBand.LabelStyle>
                                <chart:ChartPlotBandLabelStyle HorizontalTextAlignment="Start"
                                                               OffsetX="5" OffsetY="18" 
                                                               FontSize="14" TextColor="Black"/>
                            </chart:NumericalPlotBand.LabelStyle>

                        </chart:NumericalPlotBand>

                        <chart:NumericalPlotBand Start="26" End="26" Stroke="#FCD404"
                                                 StrokeWidth="2" Text="Average Temperature">

                            <chart:NumericalPlotBand.LabelStyle>
                                <chart:ChartPlotBandLabelStyle HorizontalTextAlignment="Start"
                                                               OffsetX="5" OffsetY="18" 
                                                               FontSize="14" TextColor="Black"/>
                            </chart:NumericalPlotBand.LabelStyle>

                        </chart:NumericalPlotBand>

                        <chart:NumericalPlotBand Start="30" End="30" Stroke="#F77C34"
                                                 StrokeWidth="2" Text="High Temperature">

                            <chart:NumericalPlotBand.LabelStyle>
                                <chart:ChartPlotBandLabelStyle HorizontalTextAlignment="Start"
                                                               OffsetX="5" OffsetY="18" 
                                                               FontSize="14" TextColor="Black"/>
                            </chart:NumericalPlotBand.LabelStyle>

                        </chart:NumericalPlotBand>

                    </chart:NumericalPlotBandCollection>
                </chart:NumericalAxis.PlotBands>

                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Temperature [°C]" FontSize="15" 
                                          TextColor="Black"/>
                </chart:NumericalAxis.Title>

                <chart:NumericalAxis.LabelStyle>
                    <chart:ChartAxisLabelStyle LabelFormat="0°C"/>
                </chart:NumericalAxis.LabelStyle>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>

        <chart:SplineSeries ItemsSource="{Binding ClimateData}" XBindingPath="Date" 
                            YBindingPath="Value" StrokeWidth="2"
                            ShowMarkers="True" Fill="DodgerBlue">
        </chart:SplineSeries>
    </chart:SfCartesianChart>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
