   M S B A M L   `   `   `  ����E  AtraineeWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:traineeWPF
traineeWPF  5          traineeWPF.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:traineeWPF     5      8
syncfusion!http://schemas.syncfusion.com/wpf     5        N� Title$  Page1��5
      .��5      � -   5         �Name$ Page_1��5      
�������$��Disabled=�62   $
��1100��6h   $	��450��6u    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��317 �6   �� 5      $	��651 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��450 �6   .+�5   
   �� -   5         ��Name$ bordp1��5      ���#623ed0 �� CornerRadius$ 	0,50,0,30��66    K� ZIndex$ 2��6O   $��2��6`   $	��450��6q   $��0,0,301,200q�6   $��2��6�   $	��150��6�   �� 5   
   $��Center=�6X   $��Center=�6u   ��6   �� *Value+ �� ElementName$ pbStatus�� �� StringFormat$ {0:0}%��6u   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 top10��5      
�������
   GridLinesVisibility$

 None=�69      RowHeaderWidth$ 0Q�6T      ColumnHeaderHeight$ 30Q�6h   $��
0,50,0,200q�6�   $ 1��6�   $	��400��6�   $	��968��6�   $��1��6�   $��2��6�   $��2��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%}   '        �� 5      "  6   .�5      ��  � ��$ 0,0,0,0q�69   �� 5        � ��
 �����64   5!      5"         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6%     5%      $ #��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *market_rank_cap+ �� UpdateSourceTrigger$ PropertyChanged=�6y     5&      $
 Name��6%    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�    63   �� *name+$ PropertyChanged=�6�     5'      $ Symbol��6%    . $	 100 6�    65   �� *symbol+$ PropertyChanged=�6�     5(      $ Current Price��6%    . $	 100 6�    6<   �� *current_price+$ PropertyChanged=�6�     5)      $ 1h��6%    . $	 100 6�    61   �� *(&price_change_percentage_1h_in_currency+$ PropertyChanged=�6�     5*      $	 24h��6%    . $	 100 6�    62   �� *)'price_change_percentage_24h_in_currency+$ PropertyChanged=�6�     5+      $ 7d��6%    .  61   �� *(&price_change_percentage_7d_in_currency+$ PropertyChanged=�6�     5,      $ Volume��6%    . $	 100 6�    65   �� *total_volume+$ PropertyChanged=�6�     5-      $ Mkt cap��6%    . $	 100 6�    66   �� *
market_cap+$ PropertyChanged=�6�   51      �� 52   
   -   5         ��Name$ P1��52   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Top 10��6j   $
��Left=�6{   $��25��6�   $��	25,70,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 53   
   -   5        $ P2��53   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Trending��6j   $
��Left=�6}   $��25��6�   $��
25,115,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 54   
   -   5        $ P3��54   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Search��6j   $
��Left=�6{   $��25��6�   $��
25,165,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 56   
   -   5        $ P5��56   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Convert��6j   $
��Left=�6|   $��25��6�   $��	25,10,0,0q�6�   $	��Top=�6�   $��90��6�   $��1��6�   58      59      