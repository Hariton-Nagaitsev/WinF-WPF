   M S B A M L   `   `   `  ����J  FLab01_ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Lab01_ExpenseItLab01_ExpenseIt  5      '    !Lab01_ExpenseIt.ExpenseReportPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Lab01_ExpenseIt     5        N� Title$  ExpenseIt - View Expense��5	      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @ExpenseAmount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       .+�5"   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Expense Report For:5$      � 5%   
   $��10q�6   $��1��6   $��1��6+    5&      �� 5'      �� 5(       5*      �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      .+�50      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�51      ��   
labelStyle#��[ 6   .��6<   Name:6C   �� 52      #��[ 6   6>   53      �� 55      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�56      �� #��[ 6   .��6<   Department:6I   �� 57      #��[ 6   6>   58      � 59      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\   .+�5;      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6      AutoGenerateColumns$ False��6R   	   RowHeaderWidth$	 0Q�6n   .@�5=        # [ 6E   $ False��6|   $	 0Q�6�   ��6   �� $ Expense��
   Columns
 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� $ @ExpenseType��  5@      $ Amount��61    6A   �� $ @ExpenseAmount��5B      5C      5D      5E      �� 5F   
   $��0��6   $��2��6%   $��0��69   $ 
Horizontal=�6F   .+�5G      �� #��[ 6   .��68   Name:6?   �� 5H      #��[ 6   ��68   �� $ @Name��6Z   5I      �� 5K   
   $��0��6   $��2��6%   $��1��69   $ 
Horizontal=�6F   .+�5L      �� #��[ 6   .��68   Department:6E   �� 5M      #��[ 6   ��68   �� $ @Department��6`   5N      5O      5P      