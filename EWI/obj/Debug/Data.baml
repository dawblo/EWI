   M S B A M L   `   `   `  ����>  :EWI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Wpf.PieChartWpf.PieChart  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      clr-namespace:EWIEWI  5	      '    !Wpf.PieChart.DoughnutChartExample   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Wpf.PieChart     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      !EWIclr-namespace:EWI     5	      $	��525��5      $
��1200��6     N� Title$
  Data��6(   .��5      � -   5         �Name$ Wykres��5      $��219,-169,389,329.8q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"     LiveCharts.Wpf.PieChart  5   
   $��1��6   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5         InnerRadius$	 100Q�6.   $��-578,0,0,20q�6@   $
��Left=�6U   $	��528��6p      Series 5   $   �� *SeriesCollection+   ChartLegend 5      "  LiveCharts.Wpf.DefaultLegend  5         
BulletSize$ 20Q�6$   66   	   DataTooltip	 5      #  LiveCharts.Wpf.DefaultTooltip  5      
   
BulletSize$
 20Q�6%   67   5        5!   
   $��1��6   $ Right=�5"      $	 100Q�6.   $��
-45,0,0,20q�6@   $
��Left=�6T   $	��592��6o    5!   $   �� *SeriesCollection2+ 5#        5$      $ 20Q�6$   66   	 5&        5'      $
 20Q�6%   67   5)      �� 5+   
   -   5        $��	Odśwież��5+      $
��Left=�6#   $��-82,-19,0,0q�6>   $	��Top=�6S   $��75��6k   6v   �� 5,   
   $��Liczba sprzętu��6   $
��Left=�6)   $��-461,-26,0,0q�6D   $	��Top=�6Z   $	��145��6r   $��WS Simple Gallifreyan)�6~   
�������$��12(�6�   �� 5-   
   $��Wykorzystanie��6   $
��Left=�6(   $��145,-22,0,0q�6C   $	��Top=�6X   $	��145��6p   $��2��6|   $��WS Simple Gallifreyan)�6�   
�������$��12(�6�   5/      51      