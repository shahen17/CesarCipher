selection = input("Encrypt(E)/Decrypt(D)")
user_data = input("Enter Phrase: ")

user_data_encrypted = []
user_data_decrypted = []
alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']

#finds the index of each char of user_data in alphabet//
if selection == "e" or selection == "E":
  for i in user_data:
    char = i
    alpha = alphabet.index(char)
    cal_data_add = alpha + 3
    cal_data_mod = cal_data_add % 26
    final_result = alphabet[cal_data_mod]
    user_data_encrypted.append(final_result)
  for item in user_data_encrypted:
    print(item, end="")

elif selection == "d" or selection == "D":
  for i in user_data:
    char = i
    alpha = alphabet.index(char)
    cal_data_add = alpha - 3
    cal_data_mod = cal_data_add % 26
    final_result = alphabet[cal_data_mod]
    user_data_decrypted.append(final_result)
  for item in user_data_decrypted:
    print(item, end= '')






    
 


    
   

    
    
     
     
  

