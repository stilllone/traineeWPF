   M S B A M L   `   `   `  ����E  AtraineeWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:traineeWPF
traineeWPF  5          traineeWPF.Page2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:traineeWPF     5        N� Title$  Page2��5	      .��5      � -   5         �Name$ 	Page2Grid��5      
�������$��Disabled=�65   $
��1100��6k   $	��450��6x    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��317 �6   �� 5      $	��651 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��450 �6   .+�5   
   �� ���#623ed0 �� CornerRadius$ 	0,50,0,30��6&    K� ZIndex$ 2��6?   $��2��6P   $	��450��6a   $��0,0,301,200q�6o   $��2��6�   $	��150��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ trending��5      
�������   GridLinesVisibility$
 None=�6<      RowHeaderWidth$ 0Q�6W   	   ColumnHeaderHeight$	 30Q�6k   $��
0,49,0,201q�6�   $ 1��6�   $	��968��6�   $	��400��6�   $��1��6�   $��2��6�   $��2��6�   
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%}   '        �� 5      "  6   .�5      ��  � ��$ 0,0,0,0q�69   �� 5       � ��
 �����64   5      5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6%     5"      $ #��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *score+ �� UpdateSourceTrigger$ PropertyChanged=�6o     5#      $
 Name��6%    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�    63   �� *name+$ PropertyChanged=�6�     5$      $ Coid Id��6%    . $	 100 6�    66   �� *	coin_id+$ PropertyChanged=�6�     5%      $ Symbol��6%    . $	 100 6�    65   �� *symbol+$ PropertyChanged=�6�     5&      $ Market Rank��6%    . $	 100 6�    6:   �� *market_cap_rank+$ PropertyChanged=�6�     5'      $ Price in Btc��6%    . $	 200 6�    6;   �� *	price_btc+$ PropertyChanged=�6�   5*      �� 5+   
   -   5         ��Name$ P1��5+   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Top 10��6j   $
��Left=�6{   $��25��6�   $��	25,70,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5,   
   -   5        $ P2��5,   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Refresh Page��6j   $
��Left=�6�   $��25��6�   $��
25,115,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5-   
   -   5        $ P3��5-   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Search��6j   $
��Left=�6{   $��25��6�   $��
25,165,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5.   
   -   5        $ P5��5.   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Convert��6j   $
��Left=�6|   $��25��6�   $��	25,10,0,0q�6�   $	��Top=�6�   $��90��6�   $��1��6�   5/      50      