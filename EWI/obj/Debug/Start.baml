   M S B A M L   `   `   `  ����`  \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart  5      > :EWI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EWIEWI 5         	EWI.Start   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      k
MetroChartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5      #localclr-namespace:EWI     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Start��5      .��5      � .+�5   
   �� 
�������$
��Left=�6&   $	��350��6A    �� RadiusY$ 10��6N    �� RadiusX$ 10��6[   
�������$��1��6{   $	��Top=�6�   $	��700��6�   $��	31,20,0,0q�6�   �� 5   
   $%��WYKORZYSTANIE PLANU FINANSOWEGO��6   $��Center=�6;   $��Center=�6X   $��WS Simple Gallifreyan)�6s   
�������$��16(�6�   $��-258,-172,965,601.6q�6�    � 5   
   -   5          �Name$ 
FrameStart��5      $�� ��6$   $
��Left=�6/   $	��400��6J   $��	10,10,0,0q�6W   $	��Top=�6j   $	��774��6�     � NavigationUIVisibility$ Hidden=�6�   �� 5   
   $��Witaj��6   $
��Left=�6    $��	55,30,0,0q�6;   $	��Top=�6N   $��36��6f   $��49��6r   $��16(�6}   �� 5   
   -   5         ��Name$
 user��5      $
��Left=�6"   $��
104,35,0,0q�6=   $
��Wrap=�6Q   $��	TextBlock��6e   $	��Top=�6v   $��25��6�    J� RenderTransformOrigin$ 	0.501,0.7&�6�   $	��115��6�   $��16(�6�   $
��Bold"�6�   � 5   
   $��2��6   .+�5      �� 
�������$
��Left=�6*   $��82��6E   $��143,154,0,0q�6Q   $ 10��6f   $ 10��6s   $	��Top=�6�   $	��194��6�   $��1��6�   
���  ��6�   �� 5      $��WYDATKI��6   $��Center=�6'   $��WS Simple Gallifreyan)�6D   
�������$��12(�6y   $��-406,154,1066,0q�6�   $	��140��6�   $��19��6�   $	��Top=�6�   �� 5      
�������$
��Left=�6*   $��82��6E   $��143,241,0,0q�6Q   $ 10��6f   $ 10��6s   $	��Top=�6�   $	��194��6�   $��1��6�   
��� � �6�   �� 5      $��DOSTĘPNE ŚRODKI��6   $��Center=�6/   $��Center=�6L   $��WS Simple Gallifreyan)�6g   
�������$��12(�6�   $��-406,-33,1066,462.6q�6�   $	��140��6�   5      � 5    
   $��35��6   $��50��6   ���	#FFCF1F1F$
��Left=�6=   $	��Top=�6X   $��155,155,0,0q�6p    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 20Q�6#   	   Color$	 	#FFECECEC��63   
   RenderingBias$
 Quality=�6E      ShadowDepth$ 1Q�6]   .+�5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ InformationOutline=�6&   $��Center=�6@   $��Bottom=�6]   $��8,0,7,0q�6x   
�������$��20��6�   $��20��6�   5%      � 5'   
   $��35��6   $��50��6   
��� � �$
��Left=�69   $	��Top=�6T   $��155,242,0,0q�6l    5(        5)      $ 20Q�6#   $	 	#FFECECEC��63   $
 Quality=�6E   $ 1Q�6]   .+�5+        $ Store=�6&   $��Center=�63   $��Bottom=�6P   $��8,0,7,0q�6k   
�������$��20��6�   $��20��6�   5,      5   /De.TorstenMandelkow.MetroChart.RadialGaugeChart  5.   
   .   (De.TorstenMandelkow.MetroChart.ChartBase   
ChartTitle$  ��6<      ChartSubTitle$  ��6J   $��180,-16,307,269.6q�6\   ��6&   Z�    Series 50      0   *De.TorstenMandelkow.MetroChart.ChartSeries     DisplayMember$ Titulo��51   )      SeriesTitle$ Consumo��53   )      ValueMember$ Porcentagem��54   )   $��Center=�6C   ��52   )   ��  �� Path$ Consumo�54   C   56      58      5:      