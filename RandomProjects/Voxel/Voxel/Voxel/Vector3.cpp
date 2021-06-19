#include "Vector3.h"

Vector3::Vector3()
{
	this->x = 0;
	this->y = 0;
	this->z = 0;
}

Vector3::Vector3(float nx, float ny, float nz)
{
	this->x = nx;
	this->y = ny;
	this->z = nz;
}


float Vector3::Dot(const Vector3& v, const Vector3& v1) {

	float ax = v.x * v1.x;
	float ay = v.y * v1.y;
	float az = v.z * v1.z;

	return ax+ay+az;
}



Vector3 Vector3::operator+(const Vector3& v) {

	float ax = this->x + v.x;
	float ay = this->y + v.y;
	float az = this->z + v.z;

	return Vector3(ax,ay,az);
}

void Vector3::operator+=(const Vector3& v) {

	this->x = this->x + v.x;
	this->x = this->y + v.y;
	this->x = this->z + v.z;

}

void Vector3::operator-=(const Vector3& v) {

	this->x = this->x - v.x;
	this->x = this->y - v.y;
	this->x = this->z - v.z;

}

bool Vector3::operator==(const Vector3& v) {

	bool bx = this->x == v.x;
	bool by = this->y == v.y;
	bool bz = this->z == v.z;

	return bx && by && bz;

}

Vector3 Vector3::operator-(const Vector3& v) {

	float ax = this->x - v.x;
	float ay = this->y - v.y;
	float az = this->z - v.z;

	return Vector3(ax, ay, az);
}

