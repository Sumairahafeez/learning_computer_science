import pycryptodome as pad
from Crypto.Cipher import DES
from Crypto.Cipher.DES3 import DES3

def encrypt_des(key, plaintext):
    cipher = DES.new(key, DES.MODE_ECB)
    padded_plaintext = pad(plaintext)
    ciphertext = cipher.encrypt(padded_plaintext)
    return ciphertext