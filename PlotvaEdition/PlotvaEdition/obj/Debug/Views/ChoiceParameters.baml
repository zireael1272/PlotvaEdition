   M S B A M L   `   `   `  ����H  DPlotvaEdition, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PlotvaEdition.ViewsPlotvaEdition.Views  5      *    $PlotvaEdition.Views.ChoiceParameters   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:PlotvaEdition.Views     5        N� Title$  ChoiceParameters��5	      .��5      � 
�������.+�5   
   �� -   5        $
��Back��5      $��
Назад��6   $
��Left=�6-   $��	20,18,0,0q�6H   $	��Top=�6[   
������ $��0q�6�   $��14(�6�   �� 5   
    �� Orientation$ Vertical=�6   $��175,53,175,282q�6,   .+�5      �� $��Вага посилки:��6   $��16(�6-   $��	10,0,0,10q�6;   �� 5      -   5        $��SelectedWeight��5      $��16(�6.   $��	10,10,0,0q�6<   �� 5      -   5        $��WeightSlider��5       � Minimum$	 0.5Q�6)    � Maximum$ 30Q�67   $	��400��6D    �� IsSnapToTickEnabled .  �� TickPlacement$ BottomRight=�5   (    �� AutoToolTipPlacement$ BottomRight=�5       �� AutoToolTipPrecision$ 1��60    �� Ticks 5      S� 0.5, 1, 2, 5, 10, 20, 30, 31R�6E   5      5      �� 5   
   -   5        $
��Next��5      $'��!Створити накладну��6   $��Center=�69   $��	0,363,0,0q�6V   $	��Top=�6i   $	��144��6�   $��43��6�   $��15(�6�   �� 5   
   $*��$  Оціночна вартість:��6   $��16(�60   $��175,173,208,213q�6>   �� 5   
   	 �� TextWrapping$
	 Wrap=�6   $	��200��6&   $��350,175,347,245q�61   $��15(�6J   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DeliveryDate��5      $��Center=�6)   $��	0,237,0,0q�6F   $	��Top=�6Y   $��13(�6q   �� 5   
   $ ��Дата доставки:��6   $
��Left=�6)   $��175,234,0,0q�6D   $	��Top=�6Y   $��16(�6q   5      5       