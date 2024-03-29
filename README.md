# COS(ЦОС)

БГУИР 7 семест ЦОС

1a. Генерация несущего сигнала различной формы:
- синусоида (гармонический сигнал);
- импульс с различной скважностью;
- треугольная;
- пилообразная;
- шум.

1б. Генерация полифонических сигналов на основе сигналов из предыдущего пункта (задание количества сигналов и форм).

1в. Модуляция параметров (амплитуда, частота) несущих сигналов, полученных в 1а при помощи модулирующих сигналов различной формы:
- синусоида;
- импульс с различной скважностью;
- треугольная;
- пилообразная;
- шум.

--------------------------------------------------------------------------------------------------------------------------

3. Реализация алгоритмов свёртки для изображений (двухмерное скользящее окно, например 3x3, 5x5, 7x7):
- обычное размытие (box blur);
- размытие по Гауссу (размер окна вычисляется по заданному среднеквадратическому отклонению σ);
- медианный фильтр;
- оператор Собеля.

--------------------------------------------------------------------------------------------------------------------------

4. Разработать программу, вычисляющую функцию корреляции двух изображений. Программа должна обеспечивать возможность расчёта функции взаимной корреляции двух различных изображений и автокорреляционную функцию одного изображения.

4а. В случае взаимной корреляции необходимо выполнить поиск фрагмента в заданном изображении. Интерфейс программы должен содержать исходное изображение, какой-либо случайный фрагмент этого же изображения, а также изображение корреляционной функции. В результате работы программы необходимо в исходном изображении выделить найденный фрагмент прямоугольником.

4б. В случае автокорреляции необходимо определить повторяющиеся фрагменты в заданном изображении. Интерфейс программы должен содержать исходное изображение и изображение автокорреляционной функции.
