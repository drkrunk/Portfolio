
#ifndef VECTOR3_H
#define VECTOR3_H
#pragma once

class Vector3
{

public:

	float x;
	float y;
	float z;

	Vector3();
	Vector3(float x, float y, float z);

	static float Dot(const Vector3& v, const Vector3& v2);

	Vector3 operator+(const Vector3& v);
	void operator+=(const Vector3& v);
	void operator-=(const Vector3& v);
	bool operator==(const Vector3& v);
	Vector3 operator-(const Vector3& v);

};
#endif

