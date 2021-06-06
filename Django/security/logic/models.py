from django.db import models
from django.contrib.auth.models import AbstractUser

class User(AbstractUser):
    is_staff = models.BooleanField(default=True)

class Product(models.Model):
    name = models.CharField(max_length=128)
    price = models.FloatField()
    created_by = models.ForeignKey(User, on_delete=models.CASCADE)


class Shopping(models.Model):
    date = models.DateTimeField()
    is_done = models.BooleanField()
    products = models.ManyToManyField(Product, through='ProductInCart')
    created_by = models.ForeignKey(User, on_delete=models.CASCADE)


class ProductInCart(models.Model):
    product = models.ForeignKey(Product, on_delete=models.CASCADE)
    shopping = models.ForeignKey(Shopping, on_delete=models.CASCADE)
    amount = models.IntegerField(default=1)
    created_by = models.ForeignKey(User, on_delete=models.CASCADE)
