"""
    Keep in mind that this file should be git-ignored
    Write echo /instance >> .gitignore
    
    This configuration file is supposed to be hidden, because it contains sensitive information
    If you use public configuration here, it kinda loses its purpose
"""
SECRET_KEY = 'MOCK_SECRET_KEY'
STRIPE_API_KEY = 'MOCK_STRIPE_API_KEY'
SQLALCHEMY_DATABASE_URI= "mysql://user:mock@localhost/db"
