   M S B A M L   `   `   `  ����E  AtraineeWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:traineeWPF
traineeWPF  5          traineeWPF.Page4   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:traineeWPF     5        N� Title$  Page4��5	      .��5      � -   5         �Name$ Convert��5      
�������$��Disabled=�63   $
��1100��6i   $	��450��6v    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��317 �6   �� 5      $	��651 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��450 �6   .+�5   
   �� -   5         ��Name$
 bord��5      ���#623ed0 �� CornerRadius$ 	0,50,0,30��64    K� ZIndex$ 1��6M   $��2��6^   $	��450��6o   $��0,0,301,200q�6}   $��2��6�   $	��150��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ConvertGrid��5      
�������   GridLinesVisibility$
 None=�6W   	   RowHeaderWidth$	 0Q�6r   
   ColumnHeaderHeight$
 30Q�6�   $��2��6�   $	��968��6�   $��2��6�   $��
0,50,0,200q�6�   $	��400��6�   $��0,0,0,0q�6�   $��1��6
  ��6(   ��  � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%}   '        �� 5      "  6   .�5      ��  � ��$ 0,0,0,0q�69   �� 5       � ��
 �����64   5      5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6%     5#      -   5        Coinname��$  Name of valute��5#   7      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6n   �� *SelectedItem+ �� ElementName$ C1��  5$      -   5        
valuta��$  Price in your valute��5$   5    . $	 125 6�    6T   �� *usd+ �� UpdateSourceTrigger$ PropertyChanged=�6�     5%      -   5        h24��$ Price Change at 24h��5%   2    . $	 100 6�    6O   �� *usd_24h_change+$ PropertyChanged=�6�   5)      �� 5+   
   -   5         ��Name$ P1��5+   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Top 10��6j   $
��Left=�6{   $��25��6�   $��	25,70,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5,   
   -   5        $ P2��5,   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Trending��6j   $
��Left=�6}   $��25��6�   $��
25,115,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5-   
   -	   5        $ P3��5-   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Search��6j   $
��Left=�6{   $��25��6�   $��
25,165,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5/   
   -
   5        $ P5��5/   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Start Convert��6j   $
��Left=�6�   $��25��6�   $��	25,10,0,0q�6�   $	��Top=�6�   $��90��6�   $��1��6�   �� 50   
   $��Coin (name)��6   
�������$
��Left=�69   $��	20,58,0,0q�6T   $	��Top=�6g   $ 2��6   $��1��6�   �� 51   
   $��Coin (valute)��6   
�������$
��Left=�6;   $��
20,102,0,0q�6V   $	��Top=�6j   $ 2��6�   $��1��6�   �� 52   
   -   5         ��Name$ C1��52   P   #��["�6   ���#623ed0$��Center=�6q   $��	10,81,0,0q�6�   $��1��6�   $	��Top=�6�   $	��100��6�   $ 2��6�   ��6�   �� *
currCoin+6  �� 53   
   -   5        $ into_��53   P   #��["�6   ���#623ed0$��Center=�6t   $��
10,125,0,0q�6�   $��1��6�   $	��Top=�6�   $	��100��6�   $ 2��6�   ��6�   �� *valute+55      56      