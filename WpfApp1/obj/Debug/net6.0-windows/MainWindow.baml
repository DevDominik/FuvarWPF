   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Fuvar��5   	   $	��600��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      $��2* �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��2* �6   6*   �� 5      6   �� 5      $��2* �6   6*   .+�5   
   �� -   5         ��Name$ btnOsszesFuvar��5      $��ÖSSZES FUVAR��6)   $��40 20q�6@   6n   �� 5   
   -   5         ��Name$ lbOsszesFuvar��5      $��1��6'   $	��n/a��67   $��Center=�6E   $��Center=�6i   6�   �� 5   
   -   5         ��Name$ cbTaxi��5      $��1��6#   $��30 20q�60   6l   �� 5   
   -   5        $ lbTaxi��5      $��1��6    $��1��6-   $	��n/a��6=   $��Center=�6K   $��Center=�6o   6�   �� 5   
   -   5        $ btnFizetesiModok��5      $��FIZETÉSI MÓDOK��6+   $��2��6D   $��40 50q�6Q   6�   �� 5   
   -   5         ��Name$ lsbFizetesiModok��5      $��2��6,   $��1��69   $��10q�6I   6W   �� 5   
   -   5        $ btnOsszesTav��5      $��0��6'   $��3��67   $ ��ÖSSZES MEGTETT TÁVOLSÁG��6D   $��40 20q�6f   6�   �� 5   
   -   5        $ lbOsszesTav��5      $��3��6%   $��1��62   $	��n/a��6B   $��Center=�6P   $��Center=�6t   6�   �� 5   
   -	   5        $ btnLeghosszabbFuvar��5      $��0��6.   $��4��6>   $��LEGHOSSZABB FUVAR��6K   $��40 60q�6g   6�   �� 5   
   -
   5        $ lsbLeghosszabbFuvar��5      $��4��6/   $��1��6<   $��10q�6L   6Z   5      5       