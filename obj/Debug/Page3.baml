   M S B A M L   `   `   `  ����E  AtraineeWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:traineeWPF
traineeWPF  5          traineeWPF.Page3   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:traineeWPF     5        N� Title$  Page3��5	      .��5      � -   5         �Name$ GridS��5      
�������$��Disabled=�61   $
��1100��6g   $	��450��6t    � ColumnDefinitions 5   
   �� 5      $	��132 �6   �� 5      $	��317 �6   �� 5      $	��651 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��450 �6   .+�5   
   �� ���#623ed0 �� CornerRadius$ 	0,50,0,30��6&    K� ZIndex$ 2��6?   $��2��6P   $	��450��6a   $��0,0,301,200q�6o   $��2��6�   $	��150��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
SearchGrid��5      
�������   GridLinesVisibility$
 None=�6>      RowHeaderWidth$ 0Q�6Y   	   ColumnHeaderHeight$	 30Q�6m   $��
0,50,0,200q�6�   $ 1��6�   $��2��6�   $��2��6�   $��1��6�   
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%T   '        �� 5      "  6   .�5      ��  � ��
 �����64   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6%     5       $  #��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *market_rank_cap+ �� UpdateSourceTrigger$ PropertyChanged=�6z     5!      $
 Name��6%    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�    63   �� *name+$ PropertyChanged=�6�     5"      $ Symbol��6%    . $	 100 6�    65   �� *symbol+$ PropertyChanged=�6�     5#      $ Id��6%    . $	 100 6~    61   �� *id+$ PropertyChanged=�6~   5&      �� 5'   
   -   5         ��Name$ P1��5'   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Top 10��6j   $
��Left=�6{   $��25��6�   $��	25,70,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5(   
   -   5        $ P2��5(   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Trending��6j   $
��Left=�6}   $��25��6�   $��
25,115,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5)   
   -   5        $ P3��5)   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Reaload Page��6j   $
��Left=�6�   $��25��6�   $��
25,165,0,0q�6�   $	��Top=�6�   $��90��6�   6�   �� 5*   
   -   5        $ P5��5*   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Convert��6j   $
��Left=�6|   $��25��6�   $��	25,10,0,0q�6�   $	��Top=�6�   $��90��6�   $��1��6�   �� 5+   
   -   5        $ Start_Search��5+   ^   ���#623ed0$��0q�6&   
�������$ 2��6M   $��Start Search��6t   $
��Left=�6�   $��25��6�   $��	25,66,0,0q�6�   $	��Top=�6�   $��90��6�   $��1��6�   �� 5,   
   -   5         ��Name$ TBSearch��5,   b   ���#623ed0$	��0.5q�6(   
�������$ 2��6Q   $
��Left=�6t   $��
23,109,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��100��6�   $��2��6�   $��1��6�   $��16��6   �� 	UndoLimit$ 20��6  5-      5.      