int[] Sort(int[] array){
	for(int i = 1; i < array.Length; i++){
		for(int j = i; j > 0 && array[j-1] > array[j]; j--){
			int tmp = array[j-1];
			array[j-1] = array[j];
			array[j] = tmp;
		}
	}
    return array;
}
void ArrShow(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write(array[i]);
    }
}
int[] array = new int[] {4, 3, 8, 0, 1, 7, 2, 5, 6, 9};
Sort(array);
ArrShow(array);