
import os

"""
    The default Flask Application Configurations
    Feel free to change any of them the way you like it at anytime.
"""

DEBUG = True  # Whether you want to debug after error
ENV = 'development'  # The type of the environment
SECRET_KEY = b'H\xbd;\xabN\x15\x03\x92\xa2\xfb!\xcah\x15\x05\x03'  # Pseudo-random bytes generated via os.urandom(16)
APPLICATION_ROOT = os.environ.get('HTTP_PORT', default=5555)  # You can either set the port or use the default one
